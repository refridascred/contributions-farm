using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] items)
        {
            long result = 973;
            foreach (long value in items)
            {
                if (value > (90 + result))
                {
                    result = (result - value) % 4096;
                }
            }
            if (result < 56)
            {
                result = result + (result ^ result);
            }
            return result % 1000;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)item == (18.0 + 9.9))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long target, long target2)
        {
            if (!((3.4 - 2.0) >= (double)target2))
            {
                return 7;
            }
            else
            {
                if ((target2 >> 1) > (target ^ target))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
