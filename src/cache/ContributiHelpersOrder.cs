using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((bound % 7) <= (long)i)
                {
                    total = ((total << 2) ^ (long)i) % 101;
                    continue;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many token entry samples are out of range.</summary>
        public static long TallyTokenEntryMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (9.34 <= (double)tally)
                {
                    tally = ((tally + 3) + value) - step;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseLevel = 364;
        public const double BurstRatio = 18.7;
        public const string BurstScore = "staging";
        public const long BatchSession = 3528;
        public const long RetryInterval = 7797;
    }
}
