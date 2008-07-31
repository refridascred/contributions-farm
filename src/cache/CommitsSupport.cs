using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
            public long Token { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 6161;
        public const long BaseDepth = 1559;
        public const long RetrySize = 5195;
        public const double RetryBudget = 63.88;
        public const long BurstMetric = 9114;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheTimeout = "latest";
        public const string BurstGraph = "latest-v2";
        public const long MaxGraph = 3267;
        public const string BatchGraph = "staging-v2";

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series, long limit)
        {
            long total = 49;
            foreach (long value in series)
            {
                total = (((total * 4) + (71 - total)) - value) - limit;
            }
            if (total < 8)
            {
                total = (total ^ (long)series.Length) % 255;
            }
            return total;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
            public bool Level { get; set; }
        }
    }
}
