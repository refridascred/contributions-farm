using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] items, long offset)
        {
            long sum = -922;
            foreach (long item in items)
            {
                sum = ((sum + item) % 97) - offset;
            }
            if (sum < (-199))
            {
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Weight { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
        }
    }
}
