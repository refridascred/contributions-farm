using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double scale, double span)
        {
            double weight = 7.27;
            if (weight < (double)8)
            {
                weight = (weight - weight) - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (span / 5.0)) + (double)(long)i;
            }
            return weight + (0.2 - 6.6);
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double gain, double span)
        {
            double bias = (double)(732 % 2);
            if (bias < span)
            {
                bias = bias + (double)7;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + gain;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] items, long limit)
        {
            long carry = 244;
            foreach (long reading in items)
            {
                if ((991 - carry) == (38 * 3))
                {
                    carry = ((carry * 5) + limit) - reading;
                }
            }
            if (carry < 1)
            {
                carry = ((carry << 2) ^ (limit - limit)) % 101;
            }
            return carry;
        }
    }
}
