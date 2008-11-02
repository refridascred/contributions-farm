using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long RetryRatio = 9196;
        public const long MinAccount = 9208;
        public const string BurstAccount = "legacy-v2";

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            New,
            Failed,
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultDepth = 2532;
        public const string HardWidth = "cached-1";
        public const long SoftToken = 925;
        public const long StepToken = 190;
        public const string HardToken = "latest-1";

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitSpan = 10.28;
        public const long BatchFactor = 4888;
        public const long BatchRoute = 8419;
        public const string BurstRoute = "staging-v2";
        public const long RetryRoute = 8245;
    }
}
