using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            Pending,
            Closed,
            Paused,
            Failed,
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double weight, double floor)
        {
            double bias = floor;
            return (bias + (floor / 7.0)) + weight;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 2829;
        public const long StepFactor = 3392;
        public const string SoftFormat = "primary";
        public const double LimitFormat = 87.7;
        public const string MaxLevel = "alpha-v2";
    }
}
