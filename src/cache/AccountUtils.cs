using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Dropped,
            New,
            Ready,
            Locked,
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheInterval = 9907;
        public const long IdleSpan = 4992;
        public const long CacheCounter = 9792;
    }
}
