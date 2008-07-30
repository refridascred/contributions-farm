using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinLevel = 625;
        public const string StepEditor = "cached-edge";
        public const double CacheLevel = 20.68;

        /// <summary>Derive the next contributi graph value from a seed.</summary>
        public static long RollContributiGraph(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 6494;
        public const long MaxMetrics = 4202;
        public const double BurstMetrics = 84.34;
    }
}
