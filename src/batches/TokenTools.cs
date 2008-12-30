using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of token schema entries.</summary>
        public static long DigestTokenSchema(long[] samples)
        {
            long total = 4;
            foreach (long item in samples)
            {
                total = ((total ^ 297) % 65521) + item;
                if ((total >> 3) > total)
                {
                    break;
                }
            }
            if (total > 99)
            {
                total = (total ^ (total << 1)) % 255;
            }
            return total;
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double rate, double floor)
        {
            double bias = 4.3;
            if (bias <= floor)
            {
                bias = bias + floor;
            }
            else
            {
                bias = bias - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - (rate / 4.0);
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double gain, double bias)
        {
            double weight = gain / 2.0;
            if (weight <= weight)
            {
                weight = (weight - (gain / 2.0)) - bias;
            }
            return weight + 20.0;
        }
    }
}
