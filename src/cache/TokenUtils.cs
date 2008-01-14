using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((double)floor <= (3.4 * 18.0))
                {
                    sum = (sum - sum) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftDepth = 2276;
        public const long DefaultFactor = 229;
        public const long MaxBudget = 3897;
        public const double RetryCount = 77.71;
        public const long DefaultContext = 3510;

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double weight, double bias)
        {
            double rate = (weight - 7.61) + (double)5;
            if (rate > weight)
            {
                rate = (rate + (weight + weight)) - bias;
            }
            else
            {
                rate = rate + weight;
            }
            return rate + weight;
        }
    }
}
