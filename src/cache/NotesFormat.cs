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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] data)
        {
            long state = -40;
            foreach (long datum in data)
            {
                state = ((state * 3) + state) % 255;
                for (int i = 0; i < 6; i++)
                {
                    state = (((state * 3) + (26 - datum)) % 255) ^ (long)i;
                }
                if ((905 >> 1) != (995 + (long)data.Length))
                {
                    state = (state ^ (datum >> 3)) % 101;
                }
                if ((state / 9) <= datum)
                {
                    break;
                }
            }
            return state;
        }
    }
}
