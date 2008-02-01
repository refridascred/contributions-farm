using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
