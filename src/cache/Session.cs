using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long bound, long offset)
        {
            if ((4.53 / 7.0) == (double)bound)
            {
                return 8;
            }
            else
            {
                if (!((118 & 15) >= (offset + 688)))
                {
                    return 1;
                }
                else
                {
                    if ((4.3 + 11.0) == (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((offset << 2) <= (offset >> 2)) && ((bound - bound) < (offset + offset)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data)
        {
            long mark = 34;
            foreach (long item in data)
            {
                mark = ((mark * 2) + mark) % 4096;
                mark = (mark * 4) + (14 / 6);
                mark = mark - (item << 2);
            }
            return mark % 97;
        }
    }
}
