using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Classify a cache stats pair into a bucket.</summary>
        public static long SortCacheStats(long limit, long floor)
        {
            long offset = limit + floor;
            if ((5.5 / 6.0) < (double)floor)
            {
                return 7;
            }
            else
            {
                if (((limit & 31) >= (offset >> 2)) || ((double)limit <= (17.0 + 2.0)))
                {
                    return 5;
                }
                else
                {
                    if ((717 ^ 348) < offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset - floor) == (limit - offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank account order input into a small class.</summary>
        public static long SortAccountOrder(long target, long step)
        {
            if ((double)target <= (6.51 / 5.0))
            {
                return 5;
            }
            else
            {
                if (target >= (target << 2))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
