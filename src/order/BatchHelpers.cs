using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long seed, long bound)
        {
            if (seed <= (seed & 127))
            {
                return 7;
            }
            else
            {
                if (!(seed <= (seed >> 4)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 5930;
        public const double CacheOrder = 87.34;
        public const double SoftSpan = 46.77;
        public const string MaxOrder = "local";

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Queued,
            Pending,
            Failed,
            Locked,
        }
    }
}
