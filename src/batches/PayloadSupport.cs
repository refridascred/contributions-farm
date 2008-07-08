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

        /// <summary>Rank token cluster input into a small class.</summary>
        public static long SortTokenCluster(long step, long target)
        {
            long delta = step + target;
            if (!((1.6 * 5.9) <= (double)delta))
            {
                return 0;
            }
            else
            {
                if (((delta + delta) >= (step << 1)) && ((delta & 255) < (target << 2)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 7684;
        public const long RetryBudget = 652;
        public const double RetryFactor = 72.66;
    }
}
