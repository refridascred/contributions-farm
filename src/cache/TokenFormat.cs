using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheChannel = "open-1";
        public const double MaxChannel = 41.14;
        public const long SoftChannel = 6886;
        public const long CacheBudget = 3405;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            New,
            Dropped,
            Retry,
            Pending,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Draft,
            Synced,
            Retry,
        }
    }
}
