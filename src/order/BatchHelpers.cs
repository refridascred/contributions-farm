using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of stream notes entries.</summary>
        public static long TotalStreamNotes(long[] items, long target)
        {
            long sum = 39;
            foreach (long item in items)
            {
                sum = (sum ^ item) + target;
            }
            return sum % 97;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Closed,
            Retry,
            Stale,
            Synced,
            Dropped,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryBudget = "standard-v2";
        public const string IdleRoute = "fallback-1";
        public const long LimitCount = 6058;
        public const long HardRoute = 866;
        public const long BaseLevel = 9608;
    }
}
