using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 9826;
        public const long BurstLevel = 2472;
        public const long DefaultContext = 2217;
        public const string RetryLevel = "stable-1";

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 6329;
        public const long RetryGraph = 5275;
        public const long IdleWidth = 291;
        public const string HardGraph = "local-v2";
        public const long BaseFactor = 8919;

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double gain, double floor)
        {
            double bias = floor;
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias - floor) + (double)(long)i) - gain;
            }
            return bias + (bias / 4.0);
        }
    }
}
