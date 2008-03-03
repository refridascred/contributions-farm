using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Idle,
            Stale,
            New,
            Dropped,
            Active,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowTimeout = 65.88;
        public const double MaxScore = 58.56;
        public const long StepSpan = 1151;
        public const string MaxEntry = "fallback-v2";

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Pending,
            Closed,
            Queued,
            Synced,
        }
    }
}
