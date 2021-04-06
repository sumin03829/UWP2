using System;

using UWP2.ViewModels;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace UWP2.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel => DataContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var myDlg = new MessageDialog("넌 대박이얌");
            myDlg.Commands.Add(new UICommand("ok"));
            await myDlg.ShowAsync();
        }
    }
}
