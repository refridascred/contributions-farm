using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Locked,
            Dropped,
            Ready,
            Draft,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 5288;
        public const double MinCount = 10.65;
        public const double RetryEditor = 41.73;
        public const long WindowEditor = 5166;
        public const long CacheWidth = 3039;

        /// <summary>Fold a list of metric checks readings.</summary>
        public static long TallyMetricChecks(long[] readings)
        {
            long mix = 0;
            foreach (long value in readings)
            {
                mix = (mix * 4) + (value + value);
            }
            return mix;
        }
    }
}
