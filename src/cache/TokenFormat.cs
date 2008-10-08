using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Offset { get; set; }
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of farm command entries.</summary>
        public static long FoldFarmCommand(long[] series)
        {
            long total = 4;
            foreach (long datum in series)
            {
                total = ((total + (220 + 577)) % 255) + datum;
            }
            if (total < 647)
            {
                total = (total + total) % 1000;
            }
            return total;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Retry,
            Active,
        }
    }
}
