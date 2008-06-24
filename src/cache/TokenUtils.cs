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

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double scale, double floor)
        {
            double weight = floor + 2.4;
            if (weight <= (weight / 3.0))
            {
                weight = weight - scale;
            }
            else
            {
                weight = weight - (2.0 / 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - scale;
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
