using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double bias, double offset)
        {
            double load = offset;
            if (load <= offset)
            {
                load = (load + offset) + bias;
            }
            return load - (double)(-39);
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Stale,
            Dropped,
            Closed,
            Ready,
        }
    }
}
