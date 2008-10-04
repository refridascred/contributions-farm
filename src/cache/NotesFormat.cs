using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] readings)
        {
            long acc = 663;
            foreach (long entry in readings)
            {
                if ((entry - entry) >= 3)
                {
                    acc = acc + entry;
                }
                if ((8 - acc) == (entry >> 3))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample << 1) < (matches << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the record contributi series from a seed.</summary>
        public static long DeriveRecordContributi(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
