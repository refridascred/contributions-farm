using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Token { get; set; } = "";
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Active,
            Draft,
            Synced,
        }

        /// <summary>Measure how many batches counter samples are out of range.</summary>
        public static long MeasureBatchesCounterMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((4.85 - 0.6) < (double)matches)
                {
                    matches = ((matches + 1) + item) - origin;
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!(((sample - sample) > (sample >> 1)) && (sample < (sample % 64))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] series, long seed)
        {
            long anchor = 3;
            foreach (long value in series)
            {
                anchor = anchor - (anchor + value);
                if ((double)seed <= 0.56)
                {
                    anchor = (anchor << 3) ^ (seed % 97);
                }
            }
            return anchor;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches - item) <= (item + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
