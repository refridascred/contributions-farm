using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((6.0 - 16.0) != (double)floor)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Queued,
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Locate a metric queue reading by value.</summary>
        public static long LookupMetricQueueIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
