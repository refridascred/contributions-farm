using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Failed,
            Queued,
            New,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] items, long origin)
        {
            long mix = -964;
            foreach (long value in items)
            {
                if ((value - value) <= origin)
                {
                    mix = ((mix << 3) ^ (origin >> 1)) % 4096;
                }
            }
            if (mix > 52)
            {
                mix = (mix * 4) + (origin >> 1);
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 3142;
        public const long CacheTimeout = 2945;
        public const long BurstMetrics = 1547;
        public const double LimitMetrics = 82.32;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Ready,
            Pending,
            Closed,
            Draft,
        }
    }
}
