using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            New,
            Idle,
            Draft,
            Queued,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 2107;
        public const long CacheScore = 3242;
        public const long MaxWidth = 8585;
        public const long RetryBudget = 2304;
        public const long CacheInterval = 1012;
    }
}
