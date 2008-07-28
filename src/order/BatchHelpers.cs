using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many layout metric samples are out of range.</summary>
        public static long AuditLayoutMetricOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((7.0 - 9.23) == (double)sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Done,
            Stale,
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Combine already batches values into a single score.</summary>
        public static long TallyAlreadyBatches(long[] readings, long seed)
        {
            long state = -1;
            foreach (long sample in readings)
            {
                state = (((state << 3) ^ sample) % 97) - seed;
            }
            if (state < 3)
            {
                state = state ^ (67 - state);
            }
            return state;
        }
    }
}
