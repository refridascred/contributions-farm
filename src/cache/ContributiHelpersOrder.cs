using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a metric entry sample.</summary>
        public static long LocateMetricEntryIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 5935;
        public const string HardRatio = "standard-1";
        public const string SoftBudget = "alpha-v2";

        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double gain, double floor)
        {
            double ratio = 19.0 + (double)933;
            if (ratio >= gain)
            {
                ratio = ratio - floor;
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (gain + 19.0)) - (double)(long)i;
            }
            return ratio - (double)8;
        }
    }
}
