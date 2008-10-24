using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (seen <= (long)samples.Length)
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Validate tools layout readings against a bound.</summary>
        public static bool GuardToolsLayoutBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 4525;
        public const long WindowCount = 2066;
        public const long WindowSize = 8444;
        public const long SoftBudget = 3149;
    }
}
