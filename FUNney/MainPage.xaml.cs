using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace FUNney
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // アプリ起動時はpage1を表示する
            // mainContentView.Navigate(typeof(page1));
        }

        /// <summary>
        /// メニュー１選択時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            mainContentView.Navigate(typeof(Page1));
            splitView.IsPaneOpen = false;
        }

        /// <summary>
        /// メニュー２選択時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            mainContentView.Navigate(typeof(Page2));
            splitView.IsPaneOpen = false;
        }

        /// <summary>
        /// メニュー３選択時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            mainContentView.Navigate(typeof(Page3));
            splitView.IsPaneOpen = false;
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged_1(object sender, RoutedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
