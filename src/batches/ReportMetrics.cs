using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSize = "strict";
        public const long DefaultSchema = 6064;
        public const double RetrySchema = 31.01;
        public const double DefaultLevel = 55.89;
        public const long HardSchema = 8952;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Combine stats graph values into a single score.</summary>
        public static long ScoreStatsGraph(long[] readings)
        {
            long anchor = 848;
            foreach (long item in readings)
            {
                if ((item >> 4) <= (item * 3))
                {
                    anchor = (anchor + (anchor << 2)) % 255;
                }
            }
            return anchor;
        }
    }
}
