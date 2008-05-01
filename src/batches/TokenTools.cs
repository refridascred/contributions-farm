using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] items, long origin)
        {
            long sum = 3;
            foreach (long value in items)
            {
                if (((double)sum == (18.0 * 3.62)) || ((origin + 846) < sum))
                {
                    sum = ((sum - sum) % 65521) - value;
                }
            }
            return sum;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Owner { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Mode { get; set; }
            public bool Offset { get; set; }
            public bool Limit { get; set; }
        }
    }
}
