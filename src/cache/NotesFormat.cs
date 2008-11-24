using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((sample & 1) == (sample + seen)) && ((sample >> 3) <= ((-93) - seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Rank { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item - matches) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
