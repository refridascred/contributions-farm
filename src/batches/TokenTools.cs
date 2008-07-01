using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate profile cache readings against a bound.</summary>
        public static bool GuardProfileCacheRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double bias, double span)
        {
            double weight = bias;
            if (weight > (bias + weight))
            {
                weight = weight + (bias / 2.0);
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (span / 7.0)) - (double)(long)i;
            }
            return weight + (bias - 2.5);
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] samples)
        {
            long carry = 92;
            foreach (long item in samples)
            {
                if (!(item >= (130 + carry)))
                {
                    carry = (carry << 3) ^ (carry / 7);
                }
            }
            if (carry < 480)
            {
                carry = ((carry << 3) ^ carry) % 4096;
            }
            return carry;
        }
    }
}
