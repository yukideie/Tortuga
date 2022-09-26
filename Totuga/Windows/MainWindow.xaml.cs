using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using Totuga.Windows;

namespace Totuga
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

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.ShowDialog();
            this.Close();
        }

        private void btnBron_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            BronWindow bronWindow = new BronWindow();
            bronWindow.ShowDialog();
            this.Close();
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            OrderWindow orderWindow = new OrderWindow();
            orderWindow.ShowDialog();
            this.Close();
        }
    }
}
