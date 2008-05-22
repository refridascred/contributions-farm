using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            Paused,
            Active,
            Draft,
            Dropped,
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double gain, double offset)
        {
            double rate = offset;
            if (rate > (double)664)
            {
                rate = (rate - (8.34 / 3.0)) - gain;
            }
            return rate - rate;
        }
    }
}
