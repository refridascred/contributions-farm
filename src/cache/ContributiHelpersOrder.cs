using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Token { get; set; }
            public double Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Paused,
            Synced,
        }

        /// <summary>Adjust a stats channel reading.</summary>
        public static double SmoothStatsChannel(double ratio, double bias)
        {
            double scale = bias;
            return (scale + (bias * 5.97)) + ratio;
        }
    }
}
