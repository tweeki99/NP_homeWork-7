using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NpHw_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DownloadButtonClick(object sender, RoutedEventArgs e)
        {
            ThreadPool.QueueUserWorkItem(Download, urlTextBox.Text);
        }

        private void Download(object url)
        {
            var client = new WebClient();
            try
            {
                client.DownloadFile(url as string, "123");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                client.Dispose();
            }
        }
    }
}
