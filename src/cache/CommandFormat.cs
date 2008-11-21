using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((639 ^ entry) <= (195 & 3))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order cache measurements.</summary>
        public static double AdjustOrderCache(double ratio, double offset)
        {
            double rate = 19.0 / 2.0;
            if (rate > ratio)
            {
                rate = (rate + 6.1) + offset;
            }
            return rate + (double)25;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long offset, long limit)
        {
            if (2.0 >= (double)limit)
            {
                return 3;
            }
            else
            {
                if ((offset > (offset + 796)) || ((double)offset < (double)92))
                {
                    return 0;
                }
                else
                {
                    if (!((offset + 3) >= (offset << 1)))
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
}
