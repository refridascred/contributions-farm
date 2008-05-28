using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 1923;
        public const string IdleCache = "stable-v2";
        public const long LimitCache = 8382;
        public const long MaxDepth = 2981;

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string CacheLevel = "alpha-1";
        public const long BurstAlready = 507;
        public const double MinAlready = 49.12;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally >> 5) > tally)
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }
    }
}
