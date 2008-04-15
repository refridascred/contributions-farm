using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
