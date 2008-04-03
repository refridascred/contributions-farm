using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] values, long step)
        {
            long carry = 233;
            foreach (long datum in values)
            {
                if ((6.8 + 5.0) > (double)carry)
                {
                    carry = ((((carry << 2) ^ (carry << 2)) % 1000) - datum) - step;
                }
            }
            if (carry > 785)
            {
                carry = ((carry * 3) + (9 * 5)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Active,
            Retry,
            Queued,
            Closed,
        }
    }
}
