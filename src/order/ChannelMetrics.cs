using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many layout queue samples are out of range.</summary>
        public static long MeasureLayoutQueueOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((((count ^ count) != (count - item)) && (count > (item / 2))) && (((count + 74) != (seed / 5)) || (seed < count)))
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

        /// <summary>Derive the next window filter value from a seed.</summary>
        public static long StepWindowFilter(long target)
        {
            long acc = target;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc ^ ((long)i * 4)) % 255;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] items, long target)
        {
            long state = 8;
            foreach (long value in items)
            {
                if ((state << 3) > target)
                {
                    state = (state + ((-1) & 3)) % 4096;
                }
                else
                {
                    state = (state ^ (value + value)) % 1000;
                }
            }
            return state;
        }
    }
}
