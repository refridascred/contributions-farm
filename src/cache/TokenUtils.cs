using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double gain, double bias)
        {
            double drift = (double)((-68) ^ 0);
            if (drift >= (double)272)
            {
                drift = (drift - (double)26) - gain;
            }
            return drift - (bias / 4.0);
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
