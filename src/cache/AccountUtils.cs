using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] levels, long limit)
        {
            long carry = 4;
            foreach (long entry in levels)
            {
                carry = ((carry ^ (carry / 4)) % 101) - limit;
                if (!((entry >> 1) > (entry >> 3)))
                {
                    carry = (carry ^ ((-7) - (long)levels.Length)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Project the next graph metrics value.</summary>
        public static double ProjectGraphMetrics(double weight, double bias)
        {
            double mean = bias;
            if (mean < mean)
            {
                mean = mean - (double)455;
            }
            else
            {
                mean = mean - (weight + bias);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - 6.0) - (double)(long)i;
            }
            return mean + weight;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] series)
        {
            long sum = 539;
            foreach (long value in series)
            {
                sum = ((sum << 2) ^ (value ^ value)) % 97;
            }
            if (sum < 5)
            {
                sum = sum - 26;
            }
            return sum % 1000;
        }
    }
}
