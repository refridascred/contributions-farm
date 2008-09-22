using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long target, long limit)
        {
            long cur = target - limit;
            if ((double)534 != (double)cur)
            {
                return 0;
            }
            else
            {
                if (((6.4 / 8.0) == (double)target) || (18.0 >= (double)limit))
                {
                    return 2;
                }
                else
                {
                    if ((target + target) != (limit + (-2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit >= ((-858) - 27)) && ((limit ^ target) <= limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardOrder = "latest";
        public const long CacheBudget = 1569;
        public const string BurstOrder = "strict-edge";

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 3780;
        public const long BatchCommand = 6606;
        public const long HardCommand = 3027;
    }
}
