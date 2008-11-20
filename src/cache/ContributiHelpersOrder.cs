using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double ratio, double floor)
        {
            double scale = (double)(561 - 36);
            if (scale >= ratio)
            {
                scale = scale + (scale / 4.0);
            }
            else
            {
                scale = scale + ratio;
            }
            return scale + floor;
        }

        /// <summary>Measure how many order stream samples are out of range.</summary>
        public static long TallyOrderStreamOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((double)reading > (double)count) && (53 <= (reading & 63)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 5785;
        public const string CacheSpan = "local";
        public const string HardLevel = "cached-v2";
        public const string DefaultEditor = "open-edge";
        public const double DefaultRatio = 52.24;
    }
}
