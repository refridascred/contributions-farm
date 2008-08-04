using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((long)levels.Length - reading) > reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Idle,
            Queued,
            Synced,
            Retry,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Closed,
            Draft,
        }
    }
}
