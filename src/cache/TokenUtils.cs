using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark - mark) % 97;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long limit, long step)
        {
            if ((double)4 > (double)step)
            {
                return 6;
            }
            else
            {
                if ((limit >> 5) <= 4)
                {
                    return 7;
                }
                else
                {
                    if ((16.0 - 7.0) >= (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry << 2) ^ carry) % 255;
                carry = carry ^ carry;
                carry = carry - (seed + carry);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
