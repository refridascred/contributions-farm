using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two checks already measurements.</summary>
        public static double AdjustChecksAlready(double rate, double span)
        {
            double load = 5.1;
            if (load >= 2.13)
            {
                load = (load - (load + load)) + span;
            }
            return load - (rate - 18.0);
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Stale,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double ratio, double span)
        {
            double drift = ratio;
            return drift + span;
        }
    }
}
