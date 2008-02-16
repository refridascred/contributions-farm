using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Idle,
            Ready,
            New,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long limit, long origin)
        {
            long bound = limit + origin;
            if (limit < (bound - bound))
            {
                return 3;
            }
            else
            {
                if (((bound - limit) <= limit) && ((13.0 / 8.0) > (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit <= (2.83 * 2.82))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((133 - limit) != (limit ^ 48))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
