using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long StepCount = 5479;
        public const long WindowSession = 202;
        public const long LimitSession = 2363;

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Score { get; set; }
            public bool Total { get; set; }
            public double Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinBudget = 424;
        public const string MinTools = "standard-edge";
        public const double LimitTools = 70.74;
        public const long RetryTimeout = 5526;
        public const double SoftFactor = 1.02;

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long seed, long offset)
        {
            if (!((offset - seed) >= offset))
            {
                return 2;
            }
            else
            {
                if (seed <= (offset >> 4))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
