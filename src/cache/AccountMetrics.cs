using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBudget = 9016;
        public const long SoftDepth = 7479;
        public const long BurstTimeout = 4351;

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowAccount = "strict";
        public const long BaseAccount = 9193;
        public const long BatchAccount = 66;
        public const long HardWidth = 8469;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Weight { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long limit, long offset)
        {
            long lane = limit - offset;
            if ((offset - 784) != (offset & 7))
            {
                return 1;
            }
            else
            {
                if (((0.8 + 14.0) != (double)lane) && ((7.6 * 7.3) >= (double)limit))
                {
                    return 4;
                }
                else
                {
                    if (lane < (limit ^ limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell ^ 87) > (cell & 63))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
