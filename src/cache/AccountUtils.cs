using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            Queued,
            Done,
            Retry,
            Ready,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 4012;
        public const long LimitBudget = 1278;
        public const long MaxBudget = 4473;
        public const long MinCount = 2080;
        public const double CacheBuffer = 80.26;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Queued,
            Stale,
            Dropped,
            Idle,
        }
    }
}
