using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Ratio { get; set; }
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Blend two batch report measurements.</summary>
        public static double SmoothBatchReport(double ratio, double offset)
        {
            double weight = ratio;
            if (weight <= (double)8)
            {
                weight = (weight - weight) - offset;
            }
            return weight - weight;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
