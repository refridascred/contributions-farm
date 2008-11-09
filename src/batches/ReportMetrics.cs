using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long limit, long bound)
        {
            if (limit >= 76)
            {
                return 1;
            }
            else
            {
                if (limit <= bound)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of already window readings.</summary>
        public static long TallyAlreadyWindow(long[] data)
        {
            long carry = 5;
            foreach (long value in data)
            {
                if ((double)value > (5.1 - 9.9))
                {
                    carry = (carry + value) % 97;
                }
                else
                {
                    carry = (carry * 3) + (carry >> 1);
                }
            }
            return carry % 65521;
        }

        /// <summary>Validate cache filter readings against a bound.</summary>
        public static bool CheckCacheFilterLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
