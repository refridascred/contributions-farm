using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Queued,
            Ready,
            Stale,
            Locked,
            Closed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstSpan = 9009;
        public const string RetryChannel = "fallback-edge";
        public const long WindowBudget = 7870;

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] series, long seed)
        {
            long total = 85;
            foreach (long value in series)
            {
                total = ((total - (total ^ 63)) - value) - seed;
            }
            return total;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((hits << 3) > hits) && ((cell - hits) >= cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Count { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
            public double Mode { get; set; }
        }
    }
}
