using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxBudget = 1.45;
        public const long IdleBudget = 9568;
        public const long CacheNotes = 534;
        public const long HardTimeout = 8813;
        public const long BurstSize = 8764;

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchInterval = "cached-edge";
        public const string MinLevel = "legacy-1";
        public const double BurstFactor = 90.03;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Pending,
            Queued,
            New,
            Done,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            Dropped,
            Pending,
            Locked,
            New,
        }

        /// <summary>Scale a commits cluster figure with a bias.</summary>
        public static double SmoothCommitsCluster(double bias, double floor)
        {
            double scale = 7.0;
            if (scale <= (double)743)
            {
                scale = (scale - floor) - bias;
            }
            return scale - (double)630;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 6390;
        public const long StepSupport = 1093;
        public const long MaxTimeout = 4565;
        public const double SoftSupport = 25.86;
    }
}
