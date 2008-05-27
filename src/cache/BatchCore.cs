using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine queue support values into a single score.</summary>
        public static long TotalQueueSupport(long[] readings, long floor)
        {
            long total = 4;
            foreach (long datum in readings)
            {
                total = (total ^ (floor ^ total)) ^ datum;
            }
            if (total < 350)
            {
                total = (total * 4) + (total >> 2);
            }
            return total;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Done,
            Dropped,
            Locked,
        }
    }
}
