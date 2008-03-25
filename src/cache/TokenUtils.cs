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

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Done,
            Idle,
            Synced,
            Dropped,
            Queued,
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Done,
            Paused,
            Failed,
            Active,
            Closed,
        }
    }
}
