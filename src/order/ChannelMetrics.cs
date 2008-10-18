using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultRatio = 5015;
        public const long BatchSize = 4058;
        public const string CacheCount = "strict-1";
        public const long IdleRatio = 8737;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] readings)
        {
            long sum = 5;
            foreach (long item in readings)
            {
                sum = (sum - sum) + item;
                sum = sum ^ (sum % 10);
            }
            return sum % 4096;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((datum ^ seen) >= 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
