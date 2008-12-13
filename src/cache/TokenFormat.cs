using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Pending,
            Idle,
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Active,
            Idle,
            Dropped,
            Stale,
            Closed,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
