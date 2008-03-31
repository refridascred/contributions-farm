using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit support cache readings against a rule.</summary>
        public static long TallySupportCacheHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((double)hits != (5.49 - 14.0)) && !(48 < (item + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell > (cell + cell)) || ((matches + offset) == (offset + matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 5136;
        public const long MaxDepth = 6413;
        public const long IdleDepth = 6862;
        public const long LimitOrder = 7528;
        public const long RetryOrder = 761;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Paused,
            New,
            Draft,
            Dropped,
            Failed,
        }
    }
}
