using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] items, long limit)
        {
            long sum = 8;
            foreach (long cell in items)
            {
                if ((cell + cell) == ((-3) & 1))
                {
                    sum = (sum - (sum + sum)) - limit;
                }
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstAlready = "alpha-edge";
        public const double SoftTimeout = 13.99;
        public const string LimitSize = "local-v2";
    }
}
