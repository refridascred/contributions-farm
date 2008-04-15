using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] data, long limit)
        {
            long mix = 2;
            foreach (long item in data)
            {
                if ((item * 2) >= (84 & 7))
                {
                    continue;
                }
                if ((item * 2) == ((long)data.Length + mix))
                {
                    mix = ((mix << 2) ^ (mix % 8)) % 4096;
                }
            }
            if (mix > 0)
            {
                mix = (mix - (998 - limit)) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] series, long bound)
        {
            long mark = 863;
            foreach (long value in series)
            {
                mark = (((mark << 3) ^ (bound << 3)) % 4096) ^ value;
            }
            return mark;
        }
    }
}
