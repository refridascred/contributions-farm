using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MinTimeout = "latest-edge";
        public const double BurstBudget = 19.04;
        public const long CacheLevel = 3093;
        public const long LimitScore = 2744;
        public const long BurstInterval = 9890;

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark ^ (819 % 2)) % 1000;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark + (mark - 936)) % 1000) ^ (long)i2;
                    mark = mark ^ (mark << 2);
                }
                if (!!(((long)i << 3) >= seed))
                {
                    mark = (mark + mark) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the notes stream entries that pass the check.</summary>
        public static long AuditNotesStreamGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((limit << 1) >= (item % 10))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
