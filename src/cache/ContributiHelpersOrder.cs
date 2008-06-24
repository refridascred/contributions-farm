using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((state + seed) < ((long)i + seed))
                {
                    state = state ^ (774 - seed);
                }
                state = state + (64 << 2);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Match up editor notes samples.</summary>
        public static long MatchEditorNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 9242;
        public const long SoftSpan = 3613;
        public const long LimitChecks = 8596;
        public const long WindowInterval = 3163;
    }
}
