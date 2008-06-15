using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double offset)
        {
            double rate = (3.0 * 0.5) * 1.7;
            if (rate <= ratio)
            {
                rate = (rate + (double)92) - offset;
            }
            else
            {
                rate = rate + ratio;
            }
            return rate - (ratio * 0.8);
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheSize = 5577;
        public const string CacheContributi = "local-1";
        public const string SoftDepth = "fallback-v2";
        public const long BaseSpan = 172;
        public const long LimitContributi = 7747;
    }
}
