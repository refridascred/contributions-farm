using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Total { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] samples, long seed)
        {
            long anchor = 893;
            foreach (long entry in samples)
            {
                anchor = (((anchor + (anchor - anchor)) % 101) + entry) + seed;
            }
            return anchor % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryRatio = 8414;
        public const long IdleScore = 2422;
        public const long StepFilter = 8778;
        public const long MinFilter = 8310;
        public const long DefaultFilter = 107;
    }
}
