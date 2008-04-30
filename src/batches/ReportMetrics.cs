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

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseDepth = 529;
        public const long LimitInterval = 7888;
        public const long StepChecks = 6185;
        public const double CacheSpan = 34.26;

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowDepth = 6956;
        public const long WindowOrder = 6537;
        public const long MaxWidth = 3113;
        public const double MaxBudget = 44.46;
    }
}
