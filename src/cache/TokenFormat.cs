using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchBudget = 132;
        public const long StepRecord = 7366;
        public const string SoftRecord = "alpha-1";
        public const long MinTimeout = 5393;
        public const long BatchSize = 3463;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
