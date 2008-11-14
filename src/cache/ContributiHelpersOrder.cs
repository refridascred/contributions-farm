using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long floor)
        {
            long state = floor;
            for (int i = 0; i < 17; i++)
            {
                state = state - (97 * 3);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)tally != (6.0 / 5.0))
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BurstSupport = 44.65;
        public const string MaxSupport = "open-1";
        public const long LimitFactor = 4653;
        public const string MinSupport = "stable";
    }
}
