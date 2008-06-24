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

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] items, long seed)
        {
            long mix = -3;
            foreach (long value in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = ((mix << 3) ^ ((long)i % 7)) % 101;
                }
                if ((seed & 127) < (mix << 3))
                {
                    mix = mix + (7 + seed);
                }
                if ((((long)items.Length * 2) >= (0 + value)) && ((0.28 + 2.0) != (double)seed))
                {
                    break;
                }
            }
            return mix % 97;
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
