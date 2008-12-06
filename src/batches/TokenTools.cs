using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Closed,
            Done,
            Synced,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 6303;
        public const long DefaultCommand = 433;
        public const long MinCommand = 783;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Queued,
            Done,
            Closed,
            Idle,
        }
    }
}
