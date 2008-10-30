using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 5126;
        public const long DefaultRecord = 7343;
        public const long BurstBudget = 4713;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long origin, long target)
        {
            if (origin <= target)
            {
                return 8;
            }
            else
            {
                if (((target - origin) <= origin) || ((target % 2) < (67 + target)))
                {
                    return 4;
                }
                else
                {
                    if ((4.8 - 3.44) <= (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((target * 3) < (target + origin)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
