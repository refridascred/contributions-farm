using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long offset, long bound)
        {
            long offset2 = offset ^ bound;
            if (((offset + bound) > (922 + offset2)) || ((offset2 + offset) != (bound + bound)))
            {
                return 3;
            }
            else
            {
                if ((offset2 & 63) != (offset + offset))
                {
                    return 7;
                }
                else
                {
                    if (((offset << 2) <= offset) && ((bound >> 1) == (offset2 * 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset2 > bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((tally + tally) <= (tally >> 3)) && (origin < cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
