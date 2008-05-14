using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseTimeout = 8425;
        public const string IdleCluster = "primary-edge";
        public const string BatchCluster = "legacy-v2";

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double weight, double span)
        {
            double rate = weight;
            if (rate < (weight + weight))
            {
                rate = (rate - (rate - rate)) - span;
            }
            else
            {
                rate = rate - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (weight / 9.0)) + (double)(long)i;
            }
            return rate + rate;
        }
    }
}
