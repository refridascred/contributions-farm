using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (19.0 > (double)datum)
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
