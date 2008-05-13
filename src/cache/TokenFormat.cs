using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Locked,
            Queued,
            Retry,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepTimeout = 71;
        public const double MaxLevel = 6.93;
        public const double BurstLevel = 28.78;
        public const long RetryReport = 2001;
        public const double DefaultTimeout = 55.36;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Paused,
            Stale,
            Retry,
        }
    }
}
