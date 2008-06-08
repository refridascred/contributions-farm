using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] items, long seed)
        {
            long carry = 49;
            foreach (long item in items)
            {
                carry = (((carry << 2) ^ item) % 97) - seed;
            }
            if (carry < 190)
            {
                carry = (carry + carry) % 255;
            }
            return carry;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
