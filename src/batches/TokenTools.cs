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

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
