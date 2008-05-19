using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                total = (total - ((long)i * 5)) % 4096;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
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
