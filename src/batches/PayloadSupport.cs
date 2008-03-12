using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long origin, long offset)
        {
            long next = origin - offset;
            if ((offset << 2) <= (offset % 97))
            {
                return 2;
            }
            else
            {
                if (((origin + origin) != (52 + 3)) && ((double)next != (15.0 - 0.3)))
                {
                    return 8;
                }
                else
                {
                    if (origin > offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset + 780) < origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many context cache samples are out of range.</summary>
        public static long TallyContextCacheHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (floor < (977 + 2))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] levels)
        {
            long carry = 63;
            foreach (long value in levels)
            {
                if (((double)carry < (2.41 + 20.0)) && ((10.0 * 4.96) == (double)carry))
                {
                    carry = ((carry ^ (72 ^ carry)) % 101) + value;
                }
            }
            if (carry < 714)
            {
                carry = (carry + carry) % 255;
            }
            return carry;
        }
    }
}
