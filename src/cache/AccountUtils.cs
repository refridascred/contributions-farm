using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 6399;
        public const long BatchFilter = 8126;
        public const long MinFilter = 8440;
        public const long SoftFilter = 8257;

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 3) ^ (32 & 3)) % 1000;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a cache batches sample.</summary>
        public static long LookupCacheBatchesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
