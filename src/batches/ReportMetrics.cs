using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                total = (total ^ ((long)i << 2)) % 1000;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Active,
            Stale,
            Retry,
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
