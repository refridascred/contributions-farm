using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 4641;
        public const long MaxBatches = 9915;
        public const long MinScore = 4315;

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 16.15;
        public const long BurstTimeout = 5889;
        public const long IdleInterval = 1712;
        public const double WindowFactor = 73.16;

        /// <summary>Rank order cache input into a small class.</summary>
        public static long GradeOrderCache(long floor, long limit)
        {
            if ((28 <= limit) && ((0.3 - 1.0) != (double)floor))
            {
                return 0;
            }
            else
            {
                if ((limit % 100) > (649 - limit))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
