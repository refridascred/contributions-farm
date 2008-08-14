using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen + origin) >= (origin >> 5))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] items)
        {
            long state = 2;
            foreach (long item in items)
            {
                if ((double)state <= (6.8 * 0.63))
                {
                    state = (state - 498) - item;
                }
            }
            return state;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (value <= (matches << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
