using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long floor, long limit)
        {
            if ((limit + floor) <= (floor * 4))
            {
                return 1;
            }
            else
            {
                if ((2.6 - 5.1) == (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((4.0 / 6.0) >= (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((0.1 / 6.0) <= (double)floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Locked,
            Stale,
            New,
            Done,
        }

        /// <summary>Validate queue window readings against a bound.</summary>
        public static bool ValidateQueueWindowLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxWidth = 1598;
        public const long DefaultOrder = 69;
        public const long MaxOrder = 2185;
        public const long RetryOrder = 2826;
        public const long IdleOrder = 853;

        /// <summary>Look up the position of a route githubfarm sample.</summary>
        public static long SeekRouteGithubfarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
