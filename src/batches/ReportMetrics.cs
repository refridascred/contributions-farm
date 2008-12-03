using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinFactor = 3865;
        public const long MinPayload = 1720;
        public const long BasePayload = 6228;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long step, long seed)
        {
            long prev = step - seed;
            if ((double)prev > 5.0)
            {
                return 5;
            }
            else
            {
                if ((9.0 * 0.26) != (double)step)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
