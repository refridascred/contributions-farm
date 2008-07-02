using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseInterval = 27.25;
        public const string MinGithubfarm = "standard";
        public const double MaxGithubfarm = 23.44;
        public const long BatchDepth = 3159;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchMetric = "stable-v2";
        public const long LimitWidth = 4480;
        public const double SoftMetric = 57.38;
    }
}
