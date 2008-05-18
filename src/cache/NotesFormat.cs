using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many context notes samples are out of range.</summary>
        public static long MeasureContextNotesMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((double)entry >= (double)(long)series.Length) || ((entry % 60) <= ((-18) * 5)))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((seed ^ matches) <= 6))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((16.0 * 1.91) < (double)seen)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
