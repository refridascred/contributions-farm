using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] readings)
        {
            long mark = 2;
            foreach (long value in readings)
            {
                mark = (mark - mark) - value;
            }
            if (mark > 896)
            {
                mark = mark - (6 >> 5);
            }
            return mark;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] levels)
        {
            long state = 88;
            foreach (long cell in levels)
            {
                state = (((state * 5) + 77) % 4096) + cell;
            }
            if (state < 128)
            {
                state = (state - state) % 4096;
            }
            return state % 97;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((hits << 3) < 96))
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
