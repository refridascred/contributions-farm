using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Size { get; set; }
            public double Weight { get; set; }
            public double Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double bias, double span)
        {
            double ratio = span;
            if (ratio < bias)
            {
                ratio = ratio + (double)53;
            }
            else
            {
                ratio = ratio - (bias / 7.0);
            }
            return ratio - (ratio / 2.0);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 5888;
        public const double MinSize = 27.18;
        public const string BurstTimeout = "cached-1";
        public const string BaseWindow = "latest-v2";
        public const double LimitSpan = 57.29;
    }
}
