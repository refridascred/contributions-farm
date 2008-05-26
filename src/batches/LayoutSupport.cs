using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Locked,
            Done,
            Queued,
            Ready,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchBudget = 78.28;
        public const long CacheLevel = 4173;
        public const double BaseFactor = 51.52;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepDepth = 8.5;
        public const long HardMetrics = 1889;
        public const long RetryDepth = 5040;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Done,
            Retry,
            Synced,
        }
    }
}
