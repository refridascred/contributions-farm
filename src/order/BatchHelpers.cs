using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a token window reading by value.</summary>
        public static long LocateTokenWindowIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCount = 6588;
        public const long MaxCommand = 9397;
        public const string HardLevel = "staging-v2";
        public const double BurstCommand = 13.37;
        public const double RetryBudget = 84.6;

        /// <summary>Audit contributi batches readings against a rule.</summary>
        public static long MeasureContributiBatchesGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((limit - sample) == (466 * 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
