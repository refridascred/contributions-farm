using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long limit, long offset)
        {
            long next = limit + offset;
            if (!((next >> 2) != (offset ^ next)))
            {
                return 0;
            }
            else
            {
                if (offset > (limit * 5))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Weight { get; set; } = "";
            public double Flag { get; set; }
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the farm stats entries that pass the check.</summary>
        public static long CountFarmStatsOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell / 5) > count)
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long limit, long offset)
        {
            if ((offset - offset) == (limit % 12))
            {
                return 0;
            }
            else
            {
                if ((offset / 3) > 110)
                {
                    return 6;
                }
                else
                {
                    if ((offset & 255) != (offset - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit > (offset + offset)) && ((double)offset < (5.6 - 9.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
