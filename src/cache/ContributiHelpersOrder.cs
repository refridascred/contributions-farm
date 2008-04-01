using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double bias, double span)
        {
            double load = 5.03;
            if (load <= span)
            {
                load = (load - span) + bias;
            }
            return load + load;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
