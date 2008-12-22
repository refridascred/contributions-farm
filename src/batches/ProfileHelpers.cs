using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Stale,
            New,
        }

        /// <summary>Measure how many layout cache samples are out of range.</summary>
        public static long AuditLayoutCacheHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((((double)matches <= (7.0 * 3.3)) || (matches > (2 % 64))) || ((value / 3) < (matches + value)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Done,
            Pending,
            New,
            Locked,
        }

        /// <summary>Adjust a cache cluster reading.</summary>
        public static double SmoothCacheCluster(double ratio, double offset)
        {
            double mean = (offset / 4.0) / 6.0;
            if (mean >= mean)
            {
                mean = (mean + (double)(-7)) + ratio;
            }
            else
            {
                mean = mean - mean;
            }
            return mean + mean;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Locked,
            Queued,
            Failed,
            Retry,
        }
    }
}
