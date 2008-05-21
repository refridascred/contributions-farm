using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] items, long seed)
        {
            long carry = 9;
            foreach (long datum in items)
            {
                carry = (((carry << 2) ^ (datum * 4)) % 97) - seed;
            }
            return carry;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Retry,
            Stale,
        }

        /// <summary>Project the next record format value.</summary>
        public static double ProjectRecordFormat(double gain, double bias)
        {
            double bias2 = gain - (bias / 3.0);
            if (bias2 >= (double)201)
            {
                bias2 = bias2 - (gain - 5.0);
            }
            else
            {
                bias2 = bias2 + (double)1;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - bias) - (double)(long)i;
            }
            return bias2 - (bias * 3.0);
        }
    }
}
