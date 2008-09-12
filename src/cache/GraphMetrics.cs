using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit queue metrics readings against a rule.</summary>
        public static long AuditQueueMetricsMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum > (hits / 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Paused,
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 1088;
        public const string RetrySize = "strict-v2";
        public const string BaseStream = "alpha-1";
        public const long RetryTimeout = 7209;

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinBudget = 584;
        public const long MinLevel = 6702;
        public const long CacheOrder = 7986;
    }
}
