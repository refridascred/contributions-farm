using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Pending,
            New,
            Draft,
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Stale,
            Retry,
            Locked,
            Done,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            New,
            Paused,
            Closed,
            Synced,
        }
    }
}
