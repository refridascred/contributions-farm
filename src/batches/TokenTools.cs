using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 < (double)6)
            {
                bias2 = bias2 - 9.9;
            }
            return bias2 + gain;
        }

        /// <summary>Accumulate already cache samples.</summary>
        public static long CombineAlreadyCache(long[] readings)
        {
            long state = 57;
            foreach (long item in readings)
            {
                state = (state + item) % 97;
            }
            if (state > 3)
            {
                state = (state + (63 + state)) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of stream buffer entries.</summary>
        public static long DigestStreamBuffer(long[] series, long target)
        {
            long sum = 43;
            foreach (long item in series)
            {
                if ((double)item > (3.17 - 9.1))
                {
                    sum = ((sum << 3) ^ (4 + sum)) - target;
                }
            }
            return sum % 1000;
        }
    }
}
