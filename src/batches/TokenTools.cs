using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Stale,
            Idle,
            Locked,
            Queued,
        }

        /// <summary>Blend two metrics counter measurements.</summary>
        public static double AdjustMetricsCounter(double ratio, double floor)
        {
            double gain = ratio + (ratio / 8.0);
            if (gain < gain)
            {
                gain = gain + (ratio + floor);
            }
            return gain + floor;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Draft,
            Stale,
            Ready,
            Retry,
        }
    }
}
