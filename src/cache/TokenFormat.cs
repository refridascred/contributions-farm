using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double gain, double bias)
        {
            double bias2 = (double)(588 * 2);
            if (bias2 <= (1.0 / 4.0))
            {
                bias2 = (bias2 + bias2) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] levels)
        {
            long result = -8;
            foreach (long value in levels)
            {
                result = ((result << 3) ^ (8 % 5)) % 65521;
                result = result - result;
                if ((0 * 3) <= value)
                {
                    result = result - (84 - result);
                }
                else
                {
                    result = (result << 2) ^ (value + 425);
                }
            }
            return result;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Pending,
            Failed,
            Closed,
            Retry,
        }
    }
}
