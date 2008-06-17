using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 5491;
        public const long RetryChannel = 7720;
        public const double CacheChannel = 78.0;
        public const long LimitCount = 2600;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            Failed,
            Idle,
            Done,
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Pending,
            Failed,
            Ready,
            Retry,
            Dropped,
        }
    }
}
