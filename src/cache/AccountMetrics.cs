using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Dropped,
            Failed,
            Locked,
            Retry,
            Paused,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((limit - 284) >= 0)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits - item) < (item / 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 67.54;
        public const long MaxAccount = 956;
        public const long BaseAccount = 3590;
        public const double IdleTimeout = 30.38;

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
