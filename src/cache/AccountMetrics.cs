using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every route window entry stays within the limit.</summary>
        public static bool GuardRouteWindowLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Paused,
            New,
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long step, long target)
        {
            if ((double)step <= (18.0 * 5.57))
            {
                return 0;
            }
            else
            {
                if (((9.66 - 2.6) < (double)step) || (step > (target - target)))
                {
                    return 1;
                }
                else
                {
                    if (!((target * 4) <= step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Paused,
            Queued,
            Stale,
            Locked,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Paused,
            Retry,
            Idle,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepSize = 2449;
        public const long BatchLevel = 5431;
        public const long LimitReport = 9738;
        public const double StepSpan = 81.76;
        public const string LimitCount = "strict-1";
    }
}
