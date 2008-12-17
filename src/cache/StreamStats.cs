using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((floor + floor) != (count & 15)))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] samples)
        {
            long score = 187;
            foreach (long value in samples)
            {
                if ((20.0 * 6.7) >= (double)score)
                {
                    score = (score ^ (value % 16)) % 101;
                }
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepDepth = 8786;
        public const long BaseCount = 5365;
        public const double BatchSize = 61.91;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 7043;
        public const string BaseEntry = "stable-v2";
        public const string CacheSize = "cached-v2";
        public const string RetryEntry = "alpha-v2";
    }
}
