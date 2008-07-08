using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 187;
        public const double CacheReport = 66.66;
        public const long IdleWidth = 9799;
        public const long HardReport = 2653;
        public const double LimitReport = 1.03;

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long floor, long limit)
        {
            if (!(3.0 <= (double)floor))
            {
                return 5;
            }
            else
            {
                if (((limit + limit) == (floor + 9)) && ((47 - floor) <= (limit >> 2)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 4775;
        public const long BaseCluster = 6855;
        public const long RetrySize = 3228;
        public const long HardCluster = 4047;
        public const long BatchCluster = 9286;
    }
}
