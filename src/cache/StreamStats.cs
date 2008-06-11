using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepScore = 3641;
        public const long BatchRatio = 7113;
        public const long BatchContributi = 8705;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Paused,
            Synced,
            Locked,
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
