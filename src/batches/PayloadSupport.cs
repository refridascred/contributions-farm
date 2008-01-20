using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double scale, double bias)
        {
            double scale2 = bias + scale;
            if (scale2 <= (scale + bias))
            {
                scale2 = scale2 + (scale * 8.49);
            }
            return scale2 + scale2;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Locked,
            Ready,
            Closed,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Stale,
            Closed,
            Paused,
            Synced,
        }
    }
}
