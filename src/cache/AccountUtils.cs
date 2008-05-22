using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Failed,
            Stale,
            Done,
            New,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryRatio = 1519;
        public const double RetryWidth = 91.66;
        public const long BurstSchema = 493;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Locked,
            Paused,
            Closed,
            Idle,
        }
    }
}
