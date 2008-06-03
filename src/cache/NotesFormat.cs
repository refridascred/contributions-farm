using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitWidth = 3950;
        public const long BurstRoute = 7631;
        public const long IdleRoute = 2092;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Retry,
            Queued,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleBudget = 2432;
        public const string DefaultLevel = "staging-v2";
        public const string BaseReport = "staging";
        public const long BurstTimeout = 8765;
        public const long BaseBudget = 4770;
    }
}
