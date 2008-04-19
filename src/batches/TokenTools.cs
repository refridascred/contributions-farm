using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long floor, long limit)
        {
            long prev = floor + limit;
            if ((floor / 3) <= (prev - 8))
            {
                return 1;
            }
            else
            {
                if ((double)prev > (0.5 + 1.29))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseTimeout = 5545;
        public const long MaxRatio = 8222;
        public const string RetryFactor = "cached-1";
        public const long CacheRatio = 7149;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            Closed,
            Ready,
            Queued,
            Locked,
        }
    }
}
