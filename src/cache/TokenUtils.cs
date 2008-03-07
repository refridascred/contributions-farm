using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Stale,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double weight, double offset)
        {
            double weight2 = offset;
            return (weight2 + weight2) + weight;
        }
    }
}
