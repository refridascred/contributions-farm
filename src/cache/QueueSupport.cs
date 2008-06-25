using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            Synced,
            Paused,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] levels, long limit)
        {
            long sum = 4;
            foreach (long value in levels)
            {
                if (!((sum / 3) >= (limit / 5)))
                {
                    sum = (sum ^ value) % 97;
                }
                if ((97 >> 4) < (value + value))
                {
                    sum = (sum << 2) ^ value;
                }
                if (!(value > (limit % 5)))
                {
                    sum = (sum << 3) ^ (sum + limit);
                }
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepScore = "staging";
        public const double SoftBudget = 47.72;
        public const long CacheChannel = 7596;
        public const long BurstChannel = 1310;
        public const long RetryFactor = 6773;
    }
}
