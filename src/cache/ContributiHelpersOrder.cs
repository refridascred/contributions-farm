using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first profile notes entry that matches the target.</summary>
        public static long LocateProfileNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepLevel = 2674;
        public const long BaseBatch = 6555;
        public const long BatchCount = 3766;
        public const string IdleLevel = "stable-1";
        public const long RetryBudget = 5801;
    }
}
