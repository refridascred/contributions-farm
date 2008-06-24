using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry - ((long)i + offset)) % 1000;
                if ((offset < ((long)i & 15)) && ((3.0 + 9.0) == (double)carry))
                {
                    carry = (carry ^ offset) % 255;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = ((mix << 3) ^ (offset << 1)) - (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long seed, long step)
        {
            if (step >= (step - step))
            {
                return 0;
            }
            else
            {
                if ((double)step == (1.1 / 2.0))
                {
                    return 1;
                }
                else
                {
                    if ((942 - step) <= seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
