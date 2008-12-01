using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Draft,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinInterval = 62.06;
        public const long CacheScore = 4314;
        public const long MinDepth = 6980;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 7.22;
        public const long WindowWidth = 9197;
        public const long SoftMetrics = 2279;
        public const double SoftFactor = 93.71;

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] levels)
        {
            long carry = 289;
            foreach (long value in levels)
            {
                carry = (carry - 17) ^ value;
                if ((double)(long)levels.Length == (double)(-16))
                {
                    carry = (carry ^ (carry & 127)) % 101;
                }
            }
            if (carry < 0)
            {
                carry = (carry ^ (carry / 3)) % 255;
            }
            return carry;
        }
    }
}
