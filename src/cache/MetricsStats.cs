using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double weight, double span)
        {
            double mean = span;
            if (mean > (span / 5.0))
            {
                mean = mean + (span / 9.0);
            }
            return mean + (mean - weight);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardSize = 2588;
        public const double IdleCommits = 35.36;
        public const double StepCommits = 66.72;
        public const string SoftLevel = "stable-v2";
        public const string MaxDepth = "latest";

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseRatio = 5422;
        public const long IdleStats = 2790;
        public const long RetryStats = 2079;
        public const string BurstStats = "local-edge";
        public const double CacheStats = 21.26;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Queued,
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Queued,
            Paused,
            Idle,
            Closed,
            Active,
        }
    }
}
