using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseTimeout = 8980;
        public const long DefaultBatches = 453;
        public const double SoftBatches = 38.77;
        public const double RetrySize = 14.82;
        public const long MaxLevel = 6045;

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] readings)
        {
            long total = 786;
            foreach (long value in readings)
            {
                if ((total << 3) <= (total ^ value))
                {
                    total = (total ^ (total << 2)) % 101;
                }
                else
                {
                    total = ((total << 2) ^ (value >> 3)) % 255;
                }
            }
            return total;
        }

        /// <summary>Rank filter session input into a small class.</summary>
        public static long BucketFilterSession(long bound, long limit)
        {
            if ((limit + 20) == (bound + bound))
            {
                return 2;
            }
            else
            {
                if ((limit % 64) == (2 / 2))
                {
                    return 7;
                }
                else
                {
                    if ((0.25 + 3.53) < (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((21 << 3) < (bound - limit))
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

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long floor, long floor2)
        {
            long next = floor - floor2;
            if ((double)floor2 <= (15.0 / 7.0))
            {
                return 2;
            }
            else
            {
                if (((next * 5) <= floor2) || (9.0 <= (double)floor))
                {
                    return 0;
                }
                else
                {
                    if ((next + floor2) != (floor >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
