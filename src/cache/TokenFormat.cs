using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double IdleSession = 41.71;
        public const double CacheSession = 87.06;
        public const long StepSession = 228;

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long target, long target2)
        {
            long span = target - target2;
            if ((span >> 3) <= target2)
            {
                return 5;
            }
            else
            {
                if (3.66 > (double)target2)
                {
                    return 3;
                }
                else
                {
                    if ((target2 * 5) >= (target2 + 834))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
