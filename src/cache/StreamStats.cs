using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            Ready,
            Stale,
            New,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double gain, double offset)
        {
            double gain2 = gain + (0.67 - 15.0);
            if (gain2 > gain2)
            {
                gain2 = (gain2 + (double)150) + offset;
            }
            else
            {
                gain2 = gain2 - (double)45;
            }
            return gain2 - (gain2 * 6.0);
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Token { get; set; }
            public double Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
