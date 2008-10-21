using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchBudget = 28.76;
        public const long BatchSize = 5872;
        public const long IdleTimeout = 3055;
        public const double DefaultContributi = 56.85;

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
