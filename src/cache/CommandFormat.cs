using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a route support pair into a bucket.</summary>
        public static long SortRouteSupport(long limit, long origin)
        {
            if ((double)limit > (6.7 - 3.8))
            {
                return 8;
            }
            else
            {
                if (3.48 < (double)limit)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Grade a report route value against two limits.</summary>
        public static long RankReportRoute(long target, long seed)
        {
            if (((-4) + seed) >= (target + target))
            {
                return 1;
            }
            else
            {
                if ((target ^ seed) <= (target - target))
                {
                    return 3;
                }
                else
                {
                    if (!((target + seed) < (5 - seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((seed / 8) < (seed & 255)) && ((target + target) < (7 + seed)))
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

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public bool Size { get; set; }
        }
    }
}
