using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long floor, long limit)
        {
            if ((1 << 3) != (floor - limit))
            {
                return 8;
            }
            else
            {
                if ((double)limit > (1.6 + 6.0))
                {
                    return 1;
                }
                else
                {
                    if (limit < (floor - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the tools contributi series from a seed.</summary>
        public static long DeriveToolsContributi(long target)
        {
            long mark = target;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Locked,
            Done,
            Closed,
            Idle,
            Failed,
        }
    }
}
