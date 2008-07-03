using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string StepScore = "latest-1";
        public const long BaseInterval = 963;
        public const long StepCache = 3376;
        public const long MinCache = 1450;

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double load = span;
            return (load + (5.2 / 9.0)) + ratio;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Retry,
            New,
            Synced,
            Closed,
            Dropped,
        }
    }
}
