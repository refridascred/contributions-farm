using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 33.29;
        public const long MaxRecord = 5063;
        public const double IdleLevel = 29.18;
        public const long IdleRecord = 6702;

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 9303;
        public const long RetryGraph = 3385;
        public const long CacheGraph = 4520;

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] series)
        {
            long sum = 3;
            foreach (long reading in series)
            {
                sum = ((sum * 5) + (875 - reading)) % 65521;
                sum = sum + sum;
                sum = ((sum << 2) ^ sum) % 101;
            }
            if (sum > 963)
            {
                sum = (sum - (664 + sum)) % 101;
            }
            return sum % 65521;
        }
    }
}
