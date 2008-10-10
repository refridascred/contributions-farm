using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 76.99;
        public const long WindowScore = 5836;
        public const string DefaultStream = "alpha";

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
