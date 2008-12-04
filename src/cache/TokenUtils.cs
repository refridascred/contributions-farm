using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 1789;
        public const double IdleMetrics = 84.18;
        public const long CacheLevel = 9533;
        public const long BurstMetrics = 3362;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Pending,
            Idle,
            Stale,
            Synced,
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long target, long limit)
        {
            if (((5 + limit) > (target - limit)) && ((target * 2) <= target))
            {
                return 2;
            }
            else
            {
                if ((limit << 3) != (455 - limit))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
