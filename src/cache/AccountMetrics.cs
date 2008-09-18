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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (bound > (tally >> 1))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long offset, long bound)
        {
            if ((double)offset >= (double)35)
            {
                return 0;
            }
            else
            {
                if ((17.0 / 2.0) > (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 3;
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
