using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Count { get; set; }
            public long Token { get; set; }
            public double Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "cached";
        public const double SoftScore = 2.18;
        public const long DefaultSpan = 9895;
        public const double StepRatio = 3.06;
        public const long BaseCount = 7848;

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
