using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum <= seed) || (((seed << 3) > (hits << 1)) || ((seed / 8) > (518 ^ hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue stream samples are out of range.</summary>
        public static long AuditQueueStreamHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((6 <= sample) && ((339 & 255) == (sample / 3)))
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stream already input into a small class.</summary>
        public static long SortStreamAlready(long floor, long limit)
        {
            long delta = floor ^ limit;
            if ((floor + floor) >= (381 + floor))
            {
                return 2;
            }
            else
            {
                if ((delta + delta) <= (floor >> 4))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] values, long bound)
        {
            long acc = 933;
            foreach (long value in values)
            {
                acc = (((acc - ((long)values.Length % 7)) % 101) + value) - bound;
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] readings, long offset)
        {
            long state = -7;
            foreach (long datum in readings)
            {
                if (!((double)state <= (0.5 / 8.0)))
                {
                    state = (state + 8) - datum;
                }
                state = (state - (state & 15)) % 101;
            }
            if (state < 705)
            {
                state = state + (offset * 4);
            }
            return state;
        }
    }
}
