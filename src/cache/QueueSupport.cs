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

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series)
        {
            long score = 43;
            foreach (long entry in series)
            {
                score = (score - (score & 1)) - entry;
                score = (score ^ score) % 1000;
                if ((674 - 26) > (score % 7))
                {
                    break;
                }
            }
            if (score > (-360))
            {
                score = score - (score & 255);
            }
            return score % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepScore = "staging";
        public const double SoftBudget = 47.72;
        public const long CacheChannel = 7596;
        public const long BurstChannel = 1310;
        public const long RetryFactor = 6773;
    }
}
