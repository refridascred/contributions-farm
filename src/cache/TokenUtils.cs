using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowLevel = 47.46;
        public const double WindowSize = 66.61;
        public const string DefaultMetrics = "fallback-edge";
        public const long BurstBudget = 263;

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepStats = "latest-1";
        public const string RetryStats = "legacy-edge";
        public const long MinStats = 5916;
        public const long DefaultStats = 705;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long limit, long limit2)
        {
            long edge = limit + limit2;
            if ((edge % 100) == (647 % 12))
            {
                return 6;
            }
            else
            {
                if ((double)edge != (double)limit2)
                {
                    return 1;
                }
                else
                {
                    if (!(limit >= (-31)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((4.8 - 6.0) == (double)limit2)
                        {
                            return 8;
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
}
