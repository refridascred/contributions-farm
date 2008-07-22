using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double scale, double bias)
        {
            double drift = bias;
            if (drift <= (double)574)
            {
                drift = (drift - bias) - scale;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + 2.32) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Project the next format cache value.</summary>
        public static double BlendFormatCache(double rate, double floor)
        {
            double bias = 3.1;
            if (bias < (bias - rate))
            {
                bias = bias - (rate / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias - (bias - 5.5);
        }
    }
}
