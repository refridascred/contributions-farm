using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 6549;
        public const long IdleTimeout = 542;
        public const double BurstBatches = 3.53;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 3385;
        public const string StepCommits = "primary-edge";
        public const long DefaultCommits = 342;
    }
}
