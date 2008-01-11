using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((bound < (seen & 15)) && ((seen < (bound + seen)) || (4 >= (seen * 3))))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Ready,
            Done,
            Active,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen <= (double)item)
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }
    }
}
