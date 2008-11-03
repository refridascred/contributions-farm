using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Locate a batches stream reading by value.</summary>
        public static long LookupBatchesStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
