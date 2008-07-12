using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstLevel = 8564;
        public const string BurstMetric = "stable-v2";
        public const long RetrySpan = 3329;
        public const long MinMetric = 7989;
        public const string SoftMetric = "stable-edge";

        /// <summary>Define session limits and defaults.</summary>
        public const double IdleTimeout = 64.93;
        public const double StepInterval = 14.82;
        public const string LimitLevel = "stable-v2";
        public const string LimitSession = "fallback-1";
        public const double WindowSession = 30.59;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (3 > count)
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }
    }
}
