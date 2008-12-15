using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two notes githubfarm measurements.</summary>
        public static double SmoothNotesGithubfarm(double ratio, double bias)
        {
            double rate = (double)493 + (bias - 1.78);
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - rate) + (double)(long)i) + ratio;
            }
            return rate - (double)(-2);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string RetrySpan = "fallback-1";
        public const string BurstCount = "local-edge";
        public const long HardBudget = 6552;
        public const long HardRatio = 3408;
        public const long LimitSize = 696;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseInterval = 710;
        public const long WindowCount = 6923;
        public const double WindowContributi = 97.99;
        public const long HardContributi = 9005;
        public const long DefaultTimeout = 2542;

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
