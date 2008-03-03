using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 8527;
        public const long HardRecord = 9395;
        public const string SoftSize = "primary-1";
        public const double LimitDepth = 90.86;

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double weight, double floor)
        {
            double ratio = weight * 3.63;
            if (ratio < (weight * 7.2))
            {
                ratio = ratio - (ratio - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (weight * 0.42)) + (double)(long)i;
            }
            return ratio + (ratio / 6.0);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCache = "fallback";
        public const double LimitCache = 93.1;
        public const long RetryLevel = 6606;
        public const long HardCache = 9883;
        public const string DefaultCache = "legacy-v2";

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Failed,
            Retry,
            Pending,
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double weight, double offset)
        {
            double mean = weight;
            if (mean > (mean * 16.0))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (weight - mean)) + (double)(long)i;
            }
            return mean + (offset * 2.5);
        }

        /// <summary>Count the record route entries that pass the check.</summary>
        public static long AuditRecordRouteOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item - item) <= (290 / 2))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
