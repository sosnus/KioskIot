﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace KioskIot
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Button_Click(null, null);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WebView1.Navigate(new Uri(@"http://40.85.113.214:3000/?orgId=1"));
            tblPageStatus.Text =". Loading... .";
            tblPageStatus.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void WebView1_LoadCompleted(object sender, NavigationEventArgs e)
        {
            tblPageStatus.Text = ". Done! .";
            tblPageStatus.Foreground = new SolidColorBrush(Colors.Green);
            //  WebView1.Navigate(new Uri(@"http://40.85.113.214:3000/?orgId=1"));
        }
    }
}
