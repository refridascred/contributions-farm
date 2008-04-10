using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long origin, long seed)
        {
            if ((origin >> 5) == (seed << 1))
            {
                return 2;
            }
            else
            {
                if ((origin - seed) >= origin)
                {
                    return 0;
                }
                else
                {
                    if ((seed >> 4) > 7)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Paused,
            Draft,
            Retry,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
