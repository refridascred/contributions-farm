using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBatches = "strict";
        public const string RetrySpan = "stable-1";
        public const long MinBatches = 8484;
        public const long BaseBatches = 7665;

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
