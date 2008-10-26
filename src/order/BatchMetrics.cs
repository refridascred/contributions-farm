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

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 6072;
        public const long BurstToken = 7371;
        public const long WindowFactor = 417;
        public const long IdleLevel = 9653;
        public const long IdleToken = 2118;

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

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
