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

        /// <summary>Locate a layout profile reading by value.</summary>
        public static long FindLayoutProfileIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Ready,
            Retry,
        }
    }
}
