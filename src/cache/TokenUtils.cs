using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score * 2) + (300 % 5)) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 >= (rate - rate2))
            {
                rate2 = rate2 - (double)909;
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            return rate2 + (rate / 2.0);
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((carry >> 1) > (seed + (long)i))
                {
                    carry = ((carry * 3) + ((long)i % 2)) % 255;
                    continue;
                }
                if (((seed + seed) >= (seed + carry)) && ((double)carry < (8.0 + 7.0)))
                {
                    carry = (carry * 4) + (carry >> 3);
                    carry = carry + (seed * 3);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
