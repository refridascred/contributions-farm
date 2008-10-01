using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchTimeout = 3537;
        public const long LimitTimeout = 3191;
        public const long CacheMetrics = 2867;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Draft,
            Done,
            Ready,
            Queued,
            Closed,
        }
    }
}
