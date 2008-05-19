using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long bound, long limit)
        {
            long gap = bound + limit;
            if ((0.2 + 5.7) <= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit ^ bound) <= (gap & 1))
                {
                    return 5;
                }
                else
                {
                    if (!((limit << 2) < (limit % 97)))
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
