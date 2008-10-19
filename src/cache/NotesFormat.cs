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

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Locked,
            Active,
            Closed,
            Idle,
        }

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
