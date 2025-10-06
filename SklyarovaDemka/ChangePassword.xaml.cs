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
using System.Windows.Shapes;

namespace SklyarovaDemka
{
    /// <summary>
    /// Interaction logic for ChangePassword.xaml
    /// </summary>
    public partial class ChangePassword : Window
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string CurrentPassword = txtCurrentPassword.Password;
            string PasswordNew = txtPasswordNew.Password;
            string PasswordNewPod = txtPasswordNewPod.Password;
            if (string.IsNullOrWhiteSpace(CurrentPassword)||string.IsNullOrWhiteSpace(PasswordNew)||string.IsNullOrWhiteSpace(PasswordNewPod))
        {
                MessageBox.Show("Все поля обязательны для заполнения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
}
