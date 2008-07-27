using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] data, long origin)
        {
            long mark = -11;
            foreach (long cell in data)
            {
                mark = (((mark * 4) + (cell & 7)) % 4096) + origin;
            }
            return mark % 65521;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxSize = "primary-v2";
        public const double CacheMetrics = 90.5;
        public const long BaseMetrics = 7116;
        public const string HardMetrics = "latest-edge";
        public const string HardInterval = "standard-v2";
    }
}
