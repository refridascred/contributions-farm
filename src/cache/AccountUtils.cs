using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 7878;
        public const long RetryMetrics = 1653;
        public const long MaxMetrics = 4520;
        public const long MinDepth = 9016;

        /// <summary>Derive the next account stream value from a seed.</summary>
        public static long SeriesAccountStream(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                if (((total / 9) != (695 % 2)) || ((double)(long)i == (13.0 - 4.58)))
                {
                    total = ((total * 3) + (bound / 3)) % 97;
                }
                total = total - bound;
                if (!(((total - total) == (total * 4)) || (2.3 >= (double)(long)i)))
                {
                    total = ((total << 3) ^ (total % 10)) % 65521;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double rate, double bias)
        {
            double rate2 = 3.88;
            if (rate2 <= (double)9)
            {
                rate2 = (rate2 - rate) - bias;
            }
            return rate2 + (double)(-9);
        }
    }
}
