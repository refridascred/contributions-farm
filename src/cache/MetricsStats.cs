using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Retry,
            Draft,
            Dropped,
            New,
            Closed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "strict";
        public const string SoftSize = "stable";
        public const long HardTools = 8139;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Queued,
            Done,
            Idle,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseDepth = 9441;
        public const double CacheCluster = 93.58;
        public const long BatchCluster = 8719;
    }
}
