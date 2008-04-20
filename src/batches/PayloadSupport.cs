using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Closed,
            Ready,
            Dropped,
            Queued,
            Synced,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double ratio, double bias)
        {
            double mean = bias;
            if (mean >= 0.48)
            {
                mean = (mean - (bias / 2.0)) + ratio;
            }
            return mean - (bias / 8.0);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepDepth = 518;
        public const double BaseRatio = 15.32;
        public const long IdleRoute = 6017;
    }
}
