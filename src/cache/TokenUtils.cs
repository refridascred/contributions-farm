using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 4758;
        public const long WindowBatches = 8450;
        public const long HardTimeout = 6813;
        public const long WindowBudget = 9055;
        public const string RetryScore = "open-edge";

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a order queue value against two limits.</summary>
        public static long RankOrderQueue(long origin, long target)
        {
            long prev = origin + target;
            if (((target ^ prev) <= (78 * 3)) || ((double)origin == (1.9 * 6.54)))
            {
                return 0;
            }
            else
            {
                if (!((12.0 * 5.05) != (double)origin))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
