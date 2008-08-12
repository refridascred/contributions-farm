using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Stale,
            New,
            Done,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((1 < (bound ^ value)) && ((0 - 697) >= (matches << 1))) || ((60 + value) > (12 * 4)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double scale, double floor)
        {
            double weight = (double)635;
            return (weight - (floor - floor)) + scale;
        }
    }
}
