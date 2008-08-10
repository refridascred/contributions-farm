using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long floor, long floor2)
        {
            if (!((double)floor2 < (12.0 - 4.24)))
            {
                return 1;
            }
            else
            {
                if ((floor & 7) <= floor)
                {
                    return 2;
                }
                else
                {
                    if (floor <= floor2)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor << 2) <= (floor2 & 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 7379;
        public const string HardFactor = "cached-v2";
        public const long SoftBatches = 2846;
        public const long DefaultTimeout = 2784;
        public const string BaseInterval = "latest-v2";

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
        }
    }
}
