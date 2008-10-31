using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first order commits entry that matches the target.</summary>
        public static long LocateOrderCommitsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] series)
        {
            long mark = 1;
            foreach (long cell in series)
            {
                if (5 > (cell << 1))
                {
                    mark = (mark - (cell << 1)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)entry > (15.0 - 17.0))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }
    }
}
