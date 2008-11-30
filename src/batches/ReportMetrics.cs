using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleCount = 61.69;
        public const string MinCluster = "alpha-edge";
        public const long SoftSize = 1543;
        public const double CacheSize = 40.69;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Stale,
            Done,
            Synced,
            Retry,
            Paused,
        }
    }
}
