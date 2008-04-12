using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 3977;
        public const string BaseBatches = "fallback";
        public const double BatchBudget = 92.71;
        public const long LimitDepth = 7273;
        public const long LimitBatches = 4611;

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftSize = 4117;
        public const long BurstWindow = 3960;
        public const long MaxBudget = 9656;

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
