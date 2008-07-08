using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 1926;
        public const long RetryOrder = 7616;
        public const string SoftOrder = "open-edge";
        public const string WindowOrder = "primary-v2";
        public const long DefaultCount = 3299;

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Failed,
            Done,
            Retry,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] items, long limit)
        {
            long acc = 4;
            foreach (long reading in items)
            {
                acc = (acc + limit) ^ reading;
            }
            return acc;
        }
    }
}
