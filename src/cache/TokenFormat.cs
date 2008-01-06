using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryScore = 8617;
        public const string RetryFilter = "staging-v2";
        public const long LimitFilter = 5584;
        public const double DefaultFilter = 35.01;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Synced,
            Stale,
            New,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxWidth = 2545;
        public const double IdleTimeout = 40.09;
        public const long MaxLevel = 7473;
    }
}
