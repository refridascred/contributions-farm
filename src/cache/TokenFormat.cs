using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Synced,
            Stale,
            Retry,
            Locked,
            Closed,
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Dropped,
            New,
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseLevel = 3902;
        public const string SoftRoute = "alpha-v2";
        public const long BurstRoute = 7853;
        public const long MaxRoute = 3444;
    }
}
