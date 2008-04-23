using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Idle,
            Draft,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] data)
        {
            long carry = 7;
            foreach (long cell in data)
            {
                if ((57 - carry) > cell)
                {
                    carry = carry ^ (carry + cell);
                }
            }
            return carry % 97;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double scale, double span)
        {
            double rate = 7.4;
            if (rate < span)
            {
                rate = rate - (8.0 * 0.2);
            }
            else
            {
                rate = rate - (scale - scale);
            }
            return rate + (scale / 8.0);
        }
    }
}
