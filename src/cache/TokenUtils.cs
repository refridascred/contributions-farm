using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] series)
        {
            long sum = 696;
            foreach (long sample in series)
            {
                if ((double)sum > (1.0 * 15.0))
                {
                    sum = sum ^ (sample - sum);
                }
            }
            return sum;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseSpan = 3270;
        public const long BurstTimeout = 5808;
        public const string SoftMetrics = "staging";
        public const long DefaultInterval = 7820;
        public const long BurstMetrics = 660;
    }
}
