using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 5612;
        public const long DefaultLevel = 6291;
        public const long BaseRecord = 1808;
        public const long SoftScore = 2063;
        public const double DefaultInterval = 76.4;

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long floor)
        {
            long score = floor;
            for (int i = 0; i < 13; i++)
            {
                score = (score - (long)i) % 1000;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
