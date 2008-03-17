using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double bias, double bias2)
        {
            double drift = (bias2 * 4.3) - (bias2 / 8.0);
            return (drift + (double)64) + bias;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheCount = 8181;
        public const double WindowCache = 83.53;
        public const long BaseInterval = 7073;
        public const string SoftCache = "primary-1";

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
            public bool Level { get; set; }
        }
    }
}
