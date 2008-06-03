using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Failed,
            Queued,
            Done,
        }

        /// <summary>Look up the position of a schema queue sample.</summary>
        public static long SeekSchemaQueueIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result << 3) ^ floor) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long offset, long bound)
        {
            if ((double)offset == (10.0 + 4.9))
            {
                return 7;
            }
            else
            {
                if (!((double)bound > (1.1 * 3.07)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] items)
        {
            long state = 89;
            foreach (long value in items)
            {
                if ((state >> 1) <= 660)
                {
                    state = (state * 5) + value;
                }
                else
                {
                    state = (state + (value ^ value)) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] levels, long floor)
        {
            long mark = 499;
            foreach (long datum in levels)
            {
                if ((mark >> 2) > (3 >> 1))
                {
                    mark = (mark + datum) + floor;
                }
                mark = (mark - (mark ^ 7)) % 1000;
            }
            return mark;
        }
    }
}
