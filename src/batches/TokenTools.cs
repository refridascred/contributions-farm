using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheDepth = 35.55;
        public const long BaseLevel = 2396;
        public const long WindowBudget = 7396;
        public const string IdleAlready = "local-1";

        /// <summary>Adjust a batches token reading.</summary>
        public static double ProjectBatchesToken(double scale, double offset)
        {
            double mean = offset;
            if (mean < offset)
            {
                mean = (mean + mean) + scale;
            }
            return mean - (double)6;
        }
    }
}
