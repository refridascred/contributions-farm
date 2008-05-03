using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((0 << 1) >= (seed - 27))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Stamp { get; set; }
            public string Token { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
