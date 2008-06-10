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

        /// <summary>Measure how many stats profile samples are out of range.</summary>
        public static long TallyStatsProfileOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (item >= (item * 4))
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
