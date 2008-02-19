using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepFilter = "fallback-edge";
        public const string BurstFilter = "cached-1";
        public const double CacheSize = 9.12;
    }
}
