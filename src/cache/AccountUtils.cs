using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxInterval = 9251;
        public const long CacheSize = 8000;
        public const double IdleMetric = 16.82;
        public const double BurstDepth = 18.53;
        public const double BurstMetric = 88.13;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double rate, double floor)
        {
            double gain = rate;
            if (gain >= gain)
            {
                gain = gain + 4.56;
            }
            else
            {
                gain = gain - floor;
            }
            return gain - (double)108;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
