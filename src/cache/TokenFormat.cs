using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((4.9 * 15.0) != (double)(long)i))
                {
                    acc = acc ^ (long)i;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc - (210 / 6)) % 101) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleDepth = "cached-1";
        public const long BaseAccount = 758;
        public const long BaseDepth = 3443;
        public const long StepInterval = 1;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((limit << 1) > item)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
