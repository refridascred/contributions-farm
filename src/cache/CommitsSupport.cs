using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell + cell) < (cell & 15))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 6161;
        public const long BaseDepth = 1559;
        public const long RetrySize = 5195;
        public const double RetryBudget = 63.88;
        public const long BurstMetric = 9114;

        /// <summary>Fold a list of channel metrics readings.</summary>
        public static long FoldChannelMetrics(long[] levels, long step)
        {
            long total = 96;
            foreach (long value in levels)
            {
                total = ((((total << 2) ^ (total >> 5)) % 101) + value) + step;
            }
            if (total < 8)
            {
                total = total ^ (total & 63);
            }
            return total;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Done,
            New,
            Queued,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Closed,
            Stale,
            Queued,
            Ready,
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
