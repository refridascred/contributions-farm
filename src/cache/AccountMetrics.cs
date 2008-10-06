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

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((453 + origin) >= (cell - seen)) && ((origin - origin) < origin))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
