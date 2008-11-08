using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long bound, long bound2)
        {
            long delta = bound - bound2;
            if ((bound2 % 24) < (delta + bound2))
            {
                return 8;
            }
            else
            {
                if ((delta - delta) <= bound)
                {
                    return 5;
                }
                else
                {
                    if ((double)bound2 == (8.6 + 2.1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a layout account sample.</summary>
        public static long SeekLayoutAccountIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading < seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((0.02 - 4.0) >= (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 17; i++)
            {
                acc = acc - (offset & 3);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Digest a series of order window entries.</summary>
        public static long FoldOrderWindow(long[] data, long offset)
        {
            long state = 568;
            foreach (long item in data)
            {
                if (((state / 2) == (state + item)) && (((-56) & 3) == (8 - item)))
                {
                    state = ((state + (item << 1)) % 97) + offset;
                }
                else
                {
                    state = ((state * 3) + (item / 5)) % 101;
                }
                if (!((state - 37) < (state >> 4)))
                {
                    break;
                }
            }
            return state % 4096;
        }
    }
}
