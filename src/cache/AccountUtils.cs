using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Pending,
            Locked,
            Idle,
            Synced,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Failed,
            Done,
            Queued,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardLevel = "strict";
        public const string WindowSession = "primary-edge";
        public const string BurstRatio = "cached-1";
        public const long CacheSession = 1960;
    }
}
