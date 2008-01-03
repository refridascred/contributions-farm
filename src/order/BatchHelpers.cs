using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((43 - hits) <= (hits ^ hits))
                {
                    hits = ((hits + 3) + sample) - origin;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] series, long limit)
        {
            long mix = 9;
            foreach (long reading in series)
            {
                mix = ((mix * 2) + (limit >> 2)) - reading;
            }
            return mix;
        }
    }
}
