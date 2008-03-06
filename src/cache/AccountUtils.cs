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

        /// <summary>Find the first graph token entry that matches the target.</summary>
        public static long SeekGraphTokenIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
