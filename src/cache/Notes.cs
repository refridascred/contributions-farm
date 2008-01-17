using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseLevel = 1620;
        public const long SoftMetrics = 6779;
        public const long RetryMetrics = 7707;
        public const long BaseWidth = 6926;

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double scale, double floor)
        {
            double drift = scale;
            return drift + (floor - scale);
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSize = 3242;
        public const long MaxSupport = 9463;
        public const string IdleWidth = "staging-edge";

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitInterval = 9154;
        public const string BurstProfile = "cached-v2";
        public const long SoftCount = 3436;
    }
}
