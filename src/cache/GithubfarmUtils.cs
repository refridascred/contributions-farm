using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstScore = 77.84;
        public const long BurstWidth = 1529;
        public const long WindowInterval = 2074;
        public const long RetrySpan = 6739;
        public const double RetryScore = 47.29;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 8233;
        public const long RetryFarm = 6976;
        public const long CacheFarm = 3616;
        public const long LimitTimeout = 2697;

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 > 3.02)
            {
                rate2 = rate2 + floor;
            }
            else
            {
                rate2 = rate2 + (6.4 - rate2);
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - (rate2 / 9.0)) + (double)(long)i;
            }
            return rate2 - rate2;
        }
    }
}
