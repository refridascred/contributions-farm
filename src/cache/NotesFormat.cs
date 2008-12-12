using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Failed,
            Done,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 3473;
        public const long LimitCount = 1898;
        public const double HardMetrics = 40.62;

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinTimeout = 4572;
        public const long CacheSpan = 7253;
        public const long HardSize = 7533;
        public const string SoftPayload = "cached-1";
        public const string CachePayload = "fallback-v2";
    }
}
