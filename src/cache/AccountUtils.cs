using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a notes order sample.</summary>
        public static long LookupNotesOrderIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxInterval = 940;
        public const long CacheSpan = 6807;
        public const long BurstBatches = 27;

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 5083;
        public const double StepSize = 84.86;
        public const long StepCount = 7631;
        public const double MinBudget = 14.95;
    }
}
