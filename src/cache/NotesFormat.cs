using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseInterval = 94.47;
        public const double BurstSession = 32.08;
        public const long StepSession = 8079;
        public const double LimitScore = 53.21;
        public const long StepDepth = 1016;

        /// <summary>Measure how many already stream samples are out of range.</summary>
        public static long MeasureAlreadyStreamMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (bound < (bound & 1))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }
    }
}
