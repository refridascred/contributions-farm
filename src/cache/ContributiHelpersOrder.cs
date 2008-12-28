using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long bound, long offset)
        {
            if (32 < bound)
            {
                return 0;
            }
            else
            {
                if ((double)offset > (11.0 * 14.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset == (8.1 - 6.59))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset > (offset / 6))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
