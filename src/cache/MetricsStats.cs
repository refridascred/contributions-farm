using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public string Count { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Grade a already record value against two limits.</summary>
        public static long BucketAlreadyRecord(long offset, long bound)
        {
            if (bound > (bound + 6))
            {
                return 4;
            }
            else
            {
                if (((double)bound <= (7.2 / 5.0)) && ((bound / 4) >= (bound + offset)))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset != (4.1 / 3.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 1354;
        public const double BurstContext = 36.11;
        public const long LimitContext = 2437;
        public const double DefaultSpan = 47.37;
        public const long MaxScore = 4236;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
