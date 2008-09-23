using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Done,
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double scale, double bias)
        {
            double gain = 6.1;
            if (gain > (gain / 6.0))
            {
                gain = gain - bias;
            }
            else
            {
                gain = gain - (double)1;
            }
            return gain - scale;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public double Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Retry,
            Done,
            Ready,
        }
    }
}
