using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Compare every pair of batch metrics readings.</summary>
        public static long OverlapBatchMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a session already sample.</summary>
        public static long LookupSessionAlreadyIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryFactor = 15.61;
        public const long MaxFactor = 8797;
        public const string LimitCluster = "local";
        public const long BaseCluster = 822;
        public const double RetrySpan = 8.92;

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long bound, long step)
        {
            if (4 > (bound % 5))
            {
                return 0;
            }
            else
            {
                if (93 < step)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
