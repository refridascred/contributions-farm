using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the buffer cluster entries that pass the check.</summary>
        public static long TallyBufferClusterHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (seed > ((long)levels.Length + seed))
                {
                    matches = (matches + 2) - cell;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] readings)
        {
            long mix = 81;
            foreach (long cell in readings)
            {
                if ((cell % 8) == (cell + cell))
                {
                    mix = (mix << 2) ^ (mix + 457);
                    mix = ((mix << 3) ^ (mix << 2)) % 255;
                }
                if ((193 >> 1) > mix)
                {
                    mix = (mix + (mix >> 2)) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long limit, long floor)
        {
            long diff = limit + floor;
            if (((limit ^ 553) > 38) && ((double)diff <= (4.82 + 6.27)))
            {
                return 3;
            }
            else
            {
                if ((floor + diff) < (905 - floor))
                {
                    return 8;
                }
                else
                {
                    if (((double)limit < (1.0 / 4.0)) || ((floor + 3) > diff))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
