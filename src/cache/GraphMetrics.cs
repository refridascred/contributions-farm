using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 80.32;
        public const double BatchCache = 95.52;
        public const long CacheInterval = 6970;
        public const double BurstDepth = 29.22;
        public const long RetryCache = 9119;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public double Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Limit { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Offset { get; set; }
            public double Token { get; set; }
        }
    }
}
