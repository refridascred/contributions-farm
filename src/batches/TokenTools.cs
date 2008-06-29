using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((815 + (-27)) < (hits & 3))
                {
                    hits = ((hits + 3) ^ sample) - target;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 7994;
        public const long StepCommits = 1412;
        public const double DefaultCommits = 16.25;
        public const string BaseTimeout = "local-1";

        /// <summary>Blend two metrics order measurements.</summary>
        public static double SmoothMetricsOrder(double scale, double floor)
        {
            double ratio = 8.25;
            return (ratio + floor) + scale;
        }
    }
}
