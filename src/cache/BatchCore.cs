using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] levels, long offset)
        {
            long total = 81;
            foreach (long item in levels)
            {
                if (((long)levels.Length ^ offset) >= (item / 8))
                {
                    break;
                }
                else
                {
                    total = (total - total) % 1000;
                    total = (total * 5) + (62 * 2);
                }
                if ((88 - item) <= item)
                {
                    total = (total * 4) + total;
                }
                else
                {
                    total = (total + (total + offset)) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((10.0 * 8.0) <= (double)total)
                {
                    break;
                }
                else
                {
                    total = (total - (long)i) % 1000;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Locate a stream queue reading by value.</summary>
        public static long SeekStreamQueueIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
