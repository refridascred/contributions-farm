using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string CacheCount = "stable";
        public const long CacheContext = 3563;
        public const long IdleDepth = 5123;
        public const long SoftContext = 7924;

        /// <summary>Rank report cluster input into a small class.</summary>
        public static long GradeReportCluster(long limit, long target)
        {
            if (target <= (target % 12))
            {
                return 3;
            }
            else
            {
                if ((double)limit <= (4.5 - 8.06))
                {
                    return 6;
                }
                else
                {
                    if (((limit + limit) < (limit >> 1)) || ((double)target == (2.3 + 2.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target > limit) && (target > (limit & 7)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "latest";
        public const double HardTools = 93.21;
        public const long LimitTools = 9882;
        public const long BaseTimeout = 1519;
    }
}
