using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRoute = 78.04;
        public const long DefaultRoute = 6269;
        public const long SoftRoute = 7217;
        public const long WindowRoute = 9728;

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 573;
        public const long IdleTimeout = 5570;
        public const long BatchBudget = 264;
        public const string HardCount = "fallback-edge";

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Idle,
            Ready,
            New,
            Retry,
            Failed,
        }
    }
}
