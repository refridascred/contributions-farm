using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxTimeout = 7498;
        public const double BurstQueue = 31.39;
        public const string MaxFactor = "latest-1";
        public const long CacheQueue = 5556;
        public const long RetryTimeout = 8763;

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double ratio, double floor)
        {
            double scale = floor;
            if (scale <= scale)
            {
                scale = (scale - (double)260) - ratio;
            }
            return scale + (floor / 5.0);
        }
    }
}
