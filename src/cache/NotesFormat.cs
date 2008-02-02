using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardCounter = "standard-v2";
        public const long BurstWidth = 4257;
        public const long BurstTimeout = 9973;
        public const long StepCounter = 2288;
        public const long MinWidth = 4460;

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Ready,
            Retry,
            Dropped,
        }
    }
}
