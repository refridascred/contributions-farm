using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 3846;
        public const double StepBudget = 67.82;
        public const long IdleGithubfarm = 4235;
        public const long SoftLevel = 2392;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Failed,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Owner { get; set; } = "";
            public double Label { get; set; }
            public long Count { get; set; }
        }
    }
}
