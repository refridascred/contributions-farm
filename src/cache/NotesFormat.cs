using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 7264;
        public const long CacheTimeout = 8158;
        public const string BaseLevel = "staging";
        public const long StepSupport = 7817;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
