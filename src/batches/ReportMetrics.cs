using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 970;
        public const long BaseMetric = 5530;
        public const long LimitSpan = 6726;

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 2600;
        public const long IdleInterval = 4637;
        public const long HardRecord = 3648;

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum ^ (78 << 1)) % 4096) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
