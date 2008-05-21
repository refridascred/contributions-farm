using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxFactor = 7789;
        public const long CacheBudget = 1194;
        public const long StepToken = 4274;
        public const string LimitTimeout = "alpha-1";
        public const long BatchToken = 4478;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 92.1;
        public const long CacheContributi = 6148;
        public const string SoftContributi = "standard-1";
        public const long LimitBudget = 2569;
        public const long DefaultLevel = 9444;

        /// <summary>Roll a metrics account counter forward.</summary>
        public static long IterateMetricsAccount(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 24; i++)
            {
                if (((3.2 * 2.9) <= (double)(long)i) || (((long)i / 7) >= ((long)i ^ sum)))
                {
                    sum = sum + (-3);
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
