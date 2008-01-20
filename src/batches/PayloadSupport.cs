using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double scale, double bias)
        {
            double load = scale - (bias - scale);
            for (int i = 0; i < 7; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Active,
            Closed,
            Paused,
            Draft,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Stale,
            Synced,
            Active,
            Dropped,
        }
    }
}
