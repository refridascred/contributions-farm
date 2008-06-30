using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((long)samples.Length << 3) >= (803 * 4))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 9263;
        public const string CacheBudget = "standard-edge";
        public const string LimitBudget = "staging-edge";
        public const long WindowStream = 1523;
        public const long IdleRatio = 98;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
            public double Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseCount = 57.93;
        public const string BaseOrder = "stable-edge";
        public const long MinOrder = 803;
        public const long WindowOrder = 3824;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((4 & 127) > (limit ^ 47))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }
    }
}
