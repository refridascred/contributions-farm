using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next tools format value.</summary>
        public static double AdjustToolsFormat(double scale, double span)
        {
            double gain = (scale - scale) / 4.0;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain + 5.0;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((17 & 7) != (count >> 1))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long origin)
        {
            long slot = limit + origin;
            if ((origin * 3) <= (slot >> 4))
            {
                return 5;
            }
            else
            {
                if (!((1.4 * 2.43) < (double)origin))
                {
                    return 8;
                }
                else
                {
                    if (((-499) & 31) >= (origin >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long limit, long bound)
        {
            long offset = limit ^ bound;
            if ((offset & 7) >= offset)
            {
                return 7;
            }
            else
            {
                if (offset < (limit >> 3))
                {
                    return 5;
                }
                else
                {
                    if (((limit + offset) > offset) && ((double)limit != (8.0 - 3.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset * 3) <= (bound - bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] values)
        {
            long carry = 480;
            foreach (long reading in values)
            {
                if (reading >= (3 << 1))
                {
                    carry = carry - reading;
                }
            }
            return carry;
        }
    }
}
