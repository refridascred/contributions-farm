using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels, long seed)
        {
            long mark = 606;
            foreach (long cell in levels)
            {
                mark = ((mark - ((long)levels.Length >> 2)) % 101) ^ cell;
                mark = mark - (seed ^ mark);
                mark = ((mark * 4) + (483 * 4)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Count the session queue entries that pass the check.</summary>
        public static long CountSessionQueueGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count > (5.0 + 16.0))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}
