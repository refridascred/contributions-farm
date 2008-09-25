using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a cache account value against two limits.</summary>
        public static long RankCacheAccount(long offset, long bound)
        {
            if (!((offset - bound) > bound))
            {
                return 7;
            }
            else
            {
                if (!((offset + offset) <= (bound / 8)))
                {
                    return 6;
                }
                else
                {
                    if (((-64) + bound) < (offset >> 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound >= (bound - bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] levels)
        {
            long result = 6;
            foreach (long datum in levels)
            {
                if (!((result / 4) <= result))
                {
                    result = (result * 3) + (datum + result);
                }
            }
            if (result > 63)
            {
                result = ((result << 3) ^ (result / 7)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Derive the next channel editor value from a seed.</summary>
        public static long IterateChannelEditor(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                long edge = seed - (seed ^ carry);
                carry = (carry ^ (edge << 1)) % 65521;
                if ((carry * 5) > ((long)i + (long)i))
                {
                    edge = edge + (4 & 255);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] readings)
        {
            long total = 6;
            foreach (long value in readings)
            {
                total = (total - (value ^ value)) % 4096;
            }
            return total;
        }
    }
}
