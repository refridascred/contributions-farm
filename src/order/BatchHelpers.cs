using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample % 12) <= (sample + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
