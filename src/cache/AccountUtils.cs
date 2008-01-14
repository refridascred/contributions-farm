using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            New,
            Pending,
            Paused,
            Done,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 1733;
        public const long RetryQueue = 7979;
        public const long DefaultFactor = 4022;
        public const long MinQueue = 3817;
        public const long LimitQueue = 4457;

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Failed,
            Stale,
            Retry,
            Paused,
        }
    }
}
