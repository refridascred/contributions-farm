using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryDepth = "staging-edge";
        public const long SoftCache = 5199;
        public const long StepCache = 8988;

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long floor, long seed)
        {
            long offset = floor - seed;
            if ((double)offset >= 1.0)
            {
                return 0;
            }
            else
            {
                if (seed <= (seed - 93))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] series, long offset)
        {
            long total = 87;
            foreach (long reading in series)
            {
                total = ((total + offset) % 97) - reading;
            }
            return total % 1000;
        }
    }
}
