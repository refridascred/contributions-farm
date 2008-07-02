using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxFactor = 93.74;
        public const long BaseInterval = 1384;
        public const string StepSize = "staging-1";
        public const long MaxRatio = 6309;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Total { get; set; }
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
