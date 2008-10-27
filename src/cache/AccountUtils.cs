using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((limit ^ value) != (limit >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftTimeout = 7229;
        public const long RetryPayload = 4801;
        public const long BurstPayload = 3276;
        public const long MinPayload = 5320;

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Flag { get; set; }
            public double Limit { get; set; }
            public double Total { get; set; }
        }
    }
}
