using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double scale, double bias)
        {
            double mean = scale;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (bias - mean)) + (double)(long)i;
            }
            return mean + 6.02;
        }

        /// <summary>Look up the position of a cluster profile sample.</summary>
        public static long LookupClusterProfileIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 15.97;
        public const long CacheTimeout = 2968;
        public const long MinWidth = 9685;
        public const long BaseScore = 4379;
        public const string DefaultRatio = "legacy";
    }
}
