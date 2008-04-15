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

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
