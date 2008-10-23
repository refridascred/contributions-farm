using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Draft,
            Closed,
            Idle,
            Active,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Queued,
            Stale,
            Paused,
            Ready,
            Synced,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 8724;
        public const string CacheFactor = "legacy";
        public const double MinInterval = 82.42;
        public const long MaxSpan = 5177;
        public const double WindowSpan = 62.36;
    }
}
