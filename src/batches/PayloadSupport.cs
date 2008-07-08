using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Queued,
            Pending,
            Ready,
            Failed,
            Closed,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] data)
        {
            long score = 2;
            foreach (long cell in data)
            {
                if ((cell + score) != (score + cell))
                {
                    score = ((score << 3) ^ (cell << 1)) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 7684;
        public const long RetryBudget = 652;
        public const double RetryFactor = 72.66;
    }
}
