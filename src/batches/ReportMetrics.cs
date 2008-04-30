using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Active,
            Synced,
            Stale,
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
