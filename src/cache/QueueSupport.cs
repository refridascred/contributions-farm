using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long target, long limit)
        {
            long prev = target - limit;
            if (prev < (limit % 64))
            {
                return 4;
            }
            else
            {
                if ((double)prev != (1.0 / 2.0))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseBudget = "open-edge";
        public const string DefaultScore = "standard-1";
        public const long BurstDepth = 8357;
        public const long RetryInterval = 8930;
        public const string BurstBudget = "latest-edge";
    }
}
