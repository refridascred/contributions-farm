using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxBudget = 4158;
        public const string BaseTimeout = "cached";
        public const string SoftReport = "alpha-edge";
        public const string LimitReport = "legacy";
        public const long RetryReport = 1336;

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] values, long origin)
        {
            long carry = 124;
            foreach (long cell in values)
            {
                if (((cell + carry) <= (cell >> 2)) || ((9.0 + 16.0) < (double)cell))
                {
                    carry = (carry + (cell + carry)) % 4096;
                }
                else
                {
                    carry = carry ^ (origin & 3);
                }
            }
            return carry;
        }
    }
}
