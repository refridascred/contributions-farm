using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Pending,
            Synced,
            Failed,
            Dropped,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)79 <= (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowSpan = 9213;
        public const long RetrySize = 6121;
        public const double BaseCommand = 38.51;
        public const long MinCommand = 705;
        public const double WindowLevel = 69.42;
    }
}
