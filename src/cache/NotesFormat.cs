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

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum - (sum - origin)) % 1000;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
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
