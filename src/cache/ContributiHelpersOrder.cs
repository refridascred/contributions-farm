using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every format context entry stays within the limit.</summary>
        public static bool CheckFormatContextBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
