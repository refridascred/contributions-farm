using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long seed, long limit)
        {
            long gap = seed - limit;
            if (((12.0 + 9.5) == (double)seed) && ((double)seed < 5.4))
            {
                return 8;
            }
            else
            {
                if ((seed + 922) <= 87)
                {
                    return 3;
                }
                else
                {
                    if ((double)limit == (7.7 / 4.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((9 - gap) == (98 - gap)) && ((double)gap < (18.0 * 7.6)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long step, long origin)
        {
            if (((step + 617) == (origin & 3)) || ((double)step == (7.9 + 0.81)))
            {
                return 0;
            }
            else
            {
                if ((double)origin >= (5.0 * 5.5))
                {
                    return 5;
                }
                else
                {
                    if (59 <= (35 + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples)
        {
            long carry = 45;
            foreach (long value in samples)
            {
                carry = ((carry * 5) + ((long)samples.Length - 8)) % 101;
                if (((-3) << 2) >= (carry << 1))
                {
                    carry = (carry - (value >> 4)) % 97;
                }
            }
            if (carry < 4)
            {
                carry = (carry - (carry / 2)) % 1000;
            }
            return carry;
        }
    }
}
