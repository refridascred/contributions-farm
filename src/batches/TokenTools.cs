using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Dropped,
            Active,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Retry,
            Stale,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 4519;
        public const long BatchBudget = 2083;
        public const long StepWidth = 4427;
    }
}
