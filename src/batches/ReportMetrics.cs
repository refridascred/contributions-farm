using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] values, long origin)
        {
            long carry = 22;
            foreach (long datum in values)
            {
                if ((origin - carry) < (19 - origin))
                {
                    carry = (((carry << 3) ^ (carry / 4)) % 1000) - datum;
                }
            }
            return carry % 1000;
        }
    }
}
