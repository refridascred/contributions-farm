using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetryBudget = 3403;
        public const long MinTimeout = 8372;
        public const long IdleRatio = 4635;
        public const double BurstDepth = 42.66;
        public const long MaxTimeout = 2069;

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowWidth = "latest-v2";
        public const string DefaultWindow = "legacy";
        public const string MaxWindow = "staging-1";

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Locked,
            Active,
        }
    }
}
