using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit already route readings against a rule.</summary>
        public static long AuditAlreadyRouteGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally & 255) <= (tally + tally))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            Stale,
            Idle,
            Pending,
            Dropped,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryBatches = "latest-edge";
        public const long IdleBatches = 3477;
        public const long MaxBatches = 538;
        public const long CacheBatches = 134;
        public const double LimitDepth = 2.61;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepDepth = 12.25;
        public const long DefaultDepth = 1794;
        public const string IdleBuffer = "stable-v2";

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
