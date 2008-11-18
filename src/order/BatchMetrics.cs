using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally <= item)
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            New,
            Retry,
            Paused,
            Stale,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            New,
            Idle,
            Retry,
            Closed,
        }
    }
}
