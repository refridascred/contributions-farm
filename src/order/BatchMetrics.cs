using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Idle,
            Retry,
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Grade a buffer tools value against two limits.</summary>
        public static long SortBufferTools(long origin, long limit)
        {
            if (((origin % 100) <= (limit - limit)) || ((542 >> 4) <= origin))
            {
                return 7;
            }
            else
            {
                if ((676 % 60) < origin)
                {
                    return 3;
                }
                else
                {
                    if (!((double)origin < 0.9))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin >> 1) > (origin + origin)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultSpan = "stable-1";
        public const long DefaultAlready = 7419;
        public const long BatchTimeout = 9545;
        public const long MinAlready = 7647;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item & 63) >= (seen << 3))
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }
    }
}
