using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBudget = 5669;
        public const long CacheSpan = 9838;
        public const long BatchBatches = 5043;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!!((tally * 4) <= (item - item)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseTimeout = 45.73;
        public const long WindowFactor = 5120;
        public const double DefaultDepth = 49.53;
        public const long RetryBudget = 2360;
        public const double MinOrder = 44.69;
    }
}
