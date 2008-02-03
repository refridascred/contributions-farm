using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Failed,
            Stale,
            Active,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double IdleAccount = 31.51;
        public const double LimitAccount = 8.58;
        public const string RetryBudget = "strict-v2";

        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 82.97;
        public const long DefaultBuffer = 6968;
        public const long RetryBuffer = 6182;
        public const double MinSize = 58.44;
    }
}
