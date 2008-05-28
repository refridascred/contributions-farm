using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Done,
            Closed,
            New,
            Stale,
            Active,
        }

        /// <summary>Accumulate tools metric samples.</summary>
        public static long WeighToolsMetric(long[] samples, long limit)
        {
            long anchor = 24;
            foreach (long entry in samples)
            {
                anchor = (((anchor * 3) + (limit >> 2)) % 4096) ^ entry;
            }
            return anchor;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Ready,
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 4205;
        public const long LimitLevel = 2157;
        public const long WindowSchema = 1131;
        public const long RetrySchema = 1088;
        public const long CacheBudget = 875;
    }
}
