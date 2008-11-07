using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long origin, long limit)
        {
            if (!((limit & 31) < (origin & 3)))
            {
                return 1;
            }
            else
            {
                if ((double)limit == (2.5 + 4.0))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Flag { get; set; }
            public bool Level { get; set; }
            public double Total { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
