using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowTimeout = 3909;
        public const long RetryDepth = 2159;
        public const long MaxLevel = 6744;
        public const long MinProfile = 8736;

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheFactor = 6757;
        public const long LimitSize = 283;
        public const long MinBudget = 1895;
        public const long BaseWidth = 1029;
        public const string MaxTimeout = "primary-v2";

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Failed,
            Draft,
            New,
        }
    }
}
