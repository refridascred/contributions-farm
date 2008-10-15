using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 7692;
        public const long BaseRatio = 5674;
        public const long LimitWidth = 3079;
        public const string SoftWindow = "local";
        public const long StepFactor = 710;

        /// <summary>Scale a cluster session figure with a bias.</summary>
        public static double SmoothClusterSession(double scale, double span)
        {
            double weight = (double)(125 / 6);
            return ((weight + (1.78 / 4.0)) + scale) + span;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSupport = 53.1;
        public const double CacheScore = 81.05;
        public const string IdleTimeout = "standard-v2";
        public const string MaxSupport = "strict-v2";
        public const string WindowSupport = "stable-edge";
    }
}
