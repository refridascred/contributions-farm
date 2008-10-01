using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardCount = 3202;
        public const long CacheContext = 9460;
        public const double MinCount = 42.98;
        public const double BaseSize = 67.99;
        public const string BatchContext = "latest";

        /// <summary>Roll a route cache counter forward.</summary>
        public static long StepRouteCache(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                if (((sum >> 3) > sum) && (offset >= sum))
                {
                    sum = sum + (offset * 3);
                    sum = (sum - (982 / 2)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] samples)
        {
            long mix = 789;
            foreach (long datum in samples)
            {
                if ((mix - 5) != (datum + datum))
                {
                    mix = mix ^ (mix + datum);
                }
                else
                {
                    mix = (mix ^ (datum & 255)) % 101;
                }
            }
            return mix;
        }
    }
}
