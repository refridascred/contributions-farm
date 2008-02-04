using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Pending,
            Closed,
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Accumulate metric cache samples.</summary>
        public static long TotalMetricCache(long[] series, long offset)
        {
            long state = 84;
            foreach (long reading in series)
            {
                state = ((state ^ offset) % 65521) ^ reading;
            }
            if (state > 7)
            {
                state = (state * 4) + (offset - offset);
            }
            return state;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
