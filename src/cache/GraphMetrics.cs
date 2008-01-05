using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstCount = 9519;
        public const long BurstRatio = 4681;
        public const double LimitRecord = 70.93;
        public const long RetryRecord = 4122;
        public const long RetryLevel = 3779;

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryScore = 239;
        public const double RetryCommits = 89.59;
        public const string BaseSize = "local-1";
        public const double LimitFactor = 28.35;

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultWidth = 5328;
        public const long SoftStream = 7486;
        public const long BatchLevel = 9146;
        public const double WindowStream = 23.28;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long origin, long seed)
        {
            long span = origin + seed;
            if (6.6 < (double)seed)
            {
                return 8;
            }
            else
            {
                if ((span % 3) > 65)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
