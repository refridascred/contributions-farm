using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double rate, double bias)
        {
            double scale = bias;
            if (scale <= (double)1)
            {
                scale = (scale - (15.0 + scale)) - rate;
            }
            return scale + (2.9 * 8.6);
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] values)
        {
            long sum = 274;
            foreach (long item in values)
            {
                if ((sum << 1) >= (item & 1))
                {
                    sum = ((sum << 2) ^ (sum >> 1)) % 101;
                }
                if (((double)item == (double)sum) || ((sum + item) <= sum))
                {
                    sum = (sum * 2) + sum;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] levels)
        {
            long total = 269;
            foreach (long value in levels)
            {
                if ((value * 3) > (total >> 2))
                {
                    total = (total - (value >> 4)) % 1000;
                }
            }
            return total % 97;
        }
    }
}
