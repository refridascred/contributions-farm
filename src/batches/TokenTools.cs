using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double ratio, double floor)
        {
            double scale = (3.0 / 9.0) * 4.26;
            return ((scale + (double)(-958)) + ratio) + floor;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Locked,
            Active,
            Dropped,
            Ready,
            Synced,
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Count { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
