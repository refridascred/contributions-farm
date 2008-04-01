using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseSize = "legacy-edge";
        public const string HardWidth = "latest-v2";
        public const double SoftInterval = 90.85;
        public const long StepDepth = 9471;

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double bias, double bias2)
        {
            double drift = bias2;
            return (drift + (drift / 9.0)) + bias;
        }
    }
}
