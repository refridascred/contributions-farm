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

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double rate, double span)
        {
            double weight = (7.6 - span) - 9.9;
            if (weight >= weight)
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (rate - rate)) + (double)(long)i;
            }
            return weight + (double)89;
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
