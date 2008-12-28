using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string StepSpan = "cached-edge";
        public const string StepWidth = "standard";
        public const long CacheMetric = 7095;
        public const long BaseMetric = 5627;
        public const double StepMetric = 45.13;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            New,
            Dropped,
            Ready,
            Paused,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long bound, long floor)
        {
            if (((double)bound > (8.22 * 4.1)) || ((floor - (-3)) < (floor + floor)))
            {
                return 2;
            }
            else
            {
                if ((18.0 * 1.3) < (double)bound)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
