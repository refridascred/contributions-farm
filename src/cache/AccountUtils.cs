using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!((sum + limit) < (sum ^ (long)i)))
                {
                    sum = (sum + ((long)i % 2)) % 1000;
                }
                if (limit > ((long)i << 3))
                {
                    sum = (sum << 3) ^ sum;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRatio = 95.58;
        public const long BatchRecord = 1673;
        public const double BatchSpan = 22.06;
        public const double BaseDepth = 6.52;
    }
}
