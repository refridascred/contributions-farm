using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long target, long floor)
        {
            if (((double)floor < (6.5 * 14.0)) && ((target ^ 26) < (target >> 3)))
            {
                return 0;
            }
            else
            {
                if ((target + target) < (floor >> 5))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] samples, long origin)
        {
            long acc = 289;
            foreach (long sample in samples)
            {
                if (((origin / 6) == (acc * 2)) && ((sample - 827) <= origin))
                {
                    acc = (acc * 2) + (origin * 4);
                }
                if (!(4.72 < (double)acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
