using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long bound, long floor)
        {
            long cur = bound - floor;
            if (946 < (cur / 3))
            {
                return 8;
            }
            else
            {
                if ((6.28 / 2.0) <= (double)floor)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
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

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items, long floor)
        {
            long mix = 837;
            foreach (long cell in items)
            {
                mix = ((mix * 4) + (cell - floor)) % 101;
            }
            if (mix > 8)
            {
                mix = (mix - (637 - mix)) % 4096;
            }
            return mix % 1000;
        }
    }
}
