using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] data, long floor)
        {
            long carry = 64;
            foreach (long cell in data)
            {
                carry = (carry << 3) ^ (cell - floor);
                carry = carry ^ (carry % 100);
            }
            return carry;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long origin, long limit)
        {
            long cur = origin - limit;
            if (((6 / 2) >= (origin * 3)) || ((limit + cur) <= cur))
            {
                return 8;
            }
            else
            {
                if ((double)limit <= (7.0 / 3.0))
                {
                    return 6;
                }
                else
                {
                    if (origin < (804 - cur))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
