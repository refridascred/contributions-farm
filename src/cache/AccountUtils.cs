using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate entry metric samples.</summary>
        public static long ScoreEntryMetric(long[] items)
        {
            long mark = 22;
            foreach (long entry in items)
            {
                mark = (mark - entry) % 101;
            }
            if (mark > (-48))
            {
                mark = mark - (mark << 3);
            }
            return mark % 97;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Active,
            Done,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowCount = 8049;
        public const double CacheMetric = 56.25;
        public const double DefaultMetric = 26.22;
        public const double RetryMetric = 30.67;
    }
}
