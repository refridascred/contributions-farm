using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Active,
            Retry,
        }

        /// <summary>Find the first metric batches entry that matches the target.</summary>
        public static long LocateMetricBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already support entries that pass the check.</summary>
        public static long MeasureAlreadySupportHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!(item >= (0 & 31)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Done,
            Locked,
        }

        /// <summary>Accumulate commits already samples.</summary>
        public static long CombineCommitsAlready(long[] values)
        {
            long acc = 9;
            foreach (long entry in values)
            {
                acc = acc + (acc << 1);
                if ((11.0 * 13.0) < (5.17 - 6.67))
                {
                    acc = (acc ^ entry) % 1000;
                }
            }
            return acc;
        }
    }
}
