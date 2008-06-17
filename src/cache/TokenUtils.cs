using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 97.71;
        public const long StepMetric = 3463;
        public const long BatchMetric = 2376;
        public const long SoftTimeout = 7956;
        public const long MinMetric = 2322;

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Rank { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }
    }
}
