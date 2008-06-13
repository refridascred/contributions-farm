using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long target, long floor)
        {
            long span = target - floor;
            if (!((floor >> 3) < 75))
            {
                return 6;
            }
            else
            {
                if ((45 >> 1) <= (floor / 3))
                {
                    return 0;
                }
                else
                {
                    if (!((7.23 - 16.0) != (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor - target) < (span % 2)) && ((73 ^ target) > span))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 575;
        public const long HardLevel = 8481;
        public const long LimitBudget = 6636;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitFactor = "open-1";
        public const double HardWindow = 21.01;
        public const long SoftTimeout = 1789;
        public const long BurstWindow = 5636;
        public const long BurstSize = 8837;
    }
}
