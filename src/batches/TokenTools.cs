using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] values, long step)
        {
            long mark = 246;
            foreach (long value in values)
            {
                if ((double)mark <= 7.9)
                {
                    mark = (((mark << 3) ^ (mark + step)) % 4096) ^ value;
                }
                else
                {
                    mark = (mark * 4) + (step >> 4);
                }
            }
            return mark;
        }

        /// <summary>Rank window queue input into a small class.</summary>
        public static long SortWindowQueue(long floor, long origin)
        {
            if (((double)origin <= 7.96) || ((3.9 - 19.0) == (double)origin))
            {
                return 5;
            }
            else
            {
                if ((double)floor > (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] data)
        {
            long result = 553;
            foreach (long item in data)
            {
                if (result >= (72 * 3))
                {
                    result = (result - (item ^ item)) % 101;
                }
                else
                {
                    result = ((result << 3) ^ (item ^ item)) % 65521;
                }
            }
            return result;
        }
    }
}
