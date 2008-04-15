using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many route order samples are out of range.</summary>
        public static long MeasureRouteOrderGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((((double)item >= 5.0) || ((item >> 1) >= item)) || ((count + item) > count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 1257;
        public const long SoftLevel = 4621;
        public const long HardOrder = 2869;
        public const long LimitOrder = 7385;

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long limit, long bound)
        {
            if ((double)limit != (4.4 / 8.0))
            {
                return 6;
            }
            else
            {
                if ((double)limit > (2.2 * 4.4))
                {
                    return 2;
                }
                else
                {
                    if ((518 - limit) != (limit >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)bound <= (0.37 - 1.27)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Locked,
            Closed,
            Active,
            Done,
        }
    }
}
