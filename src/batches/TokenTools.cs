using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 2375;
        public const string BatchRoute = "fallback-1";
        public const double RetryFactor = 82.13;
        public const long MinLevel = 9232;
        public const long IdleSpan = 6263;

        /// <summary>Count entry already pairs that satisfy a relation.</summary>
        public static long PairEntryAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (offset > (offset + entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
