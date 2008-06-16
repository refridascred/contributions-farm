using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Active,
            Stale,
            Dropped,
            Retry,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseWidth = 40;
        public const double WindowFactor = 59.33;
        public const double StepRecord = 0.61;

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Pending,
            Stale,
            Locked,
            Paused,
            Queued,
        }
    }
}
