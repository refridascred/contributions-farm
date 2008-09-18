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

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Draft,
            Active,
            New,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long limit, long limit2)
        {
            long offset = limit + limit2;
            if ((2.0 < (double)limit) && (limit > (limit2 + offset)))
            {
                return 6;
            }
            else
            {
                if ((offset + offset) >= (limit2 ^ limit2))
                {
                    return 1;
                }
                else
                {
                    if ((42 + limit) <= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((item + item) < seen) || ((13.0 / 4.0) == (double)offset))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
