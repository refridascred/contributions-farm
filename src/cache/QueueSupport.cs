using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            Done,
            Queued,
            Paused,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string StepAccount = "alpha";
        public const double BurstRatio = 31.15;
        public const long DefaultBudget = 5456;

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftInterval = 58.8;
        public const string RetryAccount = "legacy-1";
        public const long SoftBudget = 9887;
        public const long BaseAccount = 2707;
        public const double MinAccount = 78.12;
    }
}
