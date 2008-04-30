using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank record commits input into a small class.</summary>
        public static long BucketRecordCommits(long seed, long target)
        {
            long prev = seed - target;
            if ((target - target) <= 29)
            {
                return 7;
            }
            else
            {
                if (seed < (prev / 5))
                {
                    return 3;
                }
                else
                {
                    if ((seed + prev) > (prev >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((0 < target) || (seed > target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long limit, long seed)
        {
            if ((seed - 12) >= (seed + limit))
            {
                return 0;
            }
            else
            {
                if ((double)limit < 19.0)
                {
                    return 1;
                }
                else
                {
                    if (12.0 > (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit > (limit % 10))
                        {
                            return 6;
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
        public const long WindowDepth = 6956;
        public const long WindowOrder = 6537;
        public const long MaxWidth = 3113;
        public const double MaxBudget = 44.46;
    }
}
