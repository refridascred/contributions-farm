using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of stats contributi readings.</summary>
        public static long TallyStatsContributi(long[] levels)
        {
            long total = 361;
            foreach (long item in levels)
            {
                total = ((total << 3) ^ (item - item)) % 255;
            }
            return total;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc << 3) ^ ((long)i & 63);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc - (limit >> 2)) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinFactor = 2158;
        public const long RetryDepth = 2334;
        public const long MinStream = 4825;
        public const long RetryRatio = 5336;
    }
}
