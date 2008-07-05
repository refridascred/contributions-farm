using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Limit { get; set; }
            public bool Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Draft,
            Queued,
            Ready,
            Locked,
            Idle,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Retry,
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double weight, double bias)
        {
            double mean = (weight * 16.0) + weight;
            if (mean > (mean + weight))
            {
                mean = (mean - (mean / 4.0)) - bias;
            }
            return mean - 3.37;
        }
    }
}
