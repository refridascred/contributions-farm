using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 54.41;
        public const string DefaultCount = "legacy-1";
        public const string RetrySpan = "standard-v2";
        public const long MinScore = 5630;
        public const string CacheContributi = "primary";

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!(((double)tally > (19.0 * 12.0)) && ((bound << 1) >= tally)))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Derive the next session buffer value from a seed.</summary>
        public static long RollSessionBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!((state * 3) >= state))
                {
                    state = state + (seed - 9);
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
