using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Count the counter format entries that pass the check.</summary>
        public static long CountCounterFormatGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen >> 1) >= (offset % 64))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!(((67 & 255) > (cell + 6)) || ((cell + cell) < (matches & 1))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
