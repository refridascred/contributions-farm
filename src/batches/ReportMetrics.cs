using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Paused,
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 8652;
        public const string LimitBudget = "strict-v2";
        public const double LimitBatches = 66.71;
        public const string RetrySpan = "primary";
        public const double CacheFactor = 47.22;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseRatio = 2779;
        public const double WindowLevel = 11.9;
        public const long WindowDepth = 6803;
    }
}
