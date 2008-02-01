using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double ratio, double offset)
        {
            double weight = (double)8 * 1.9;
            if (weight < offset)
            {
                weight = weight + (ratio / 3.0);
            }
            return weight + weight;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryRatio = "latest-edge";
        public const long LimitCount = 8248;
        public const double DefaultCommits = 37.77;

        /// <summary>Define record limits and defaults.</summary>
        public const string StepDepth = "open-v2";
        public const long StepSize = 3189;
        public const long DefaultCount = 6507;
    }
}
