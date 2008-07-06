using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((floor >> 4) < (value + floor))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultSize = 9.21;
        public const long MaxLayout = 5347;
        public const long BurstLayout = 9137;
        public const long RetryLayout = 8409;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Ready,
            Retry,
        }
    }
}
