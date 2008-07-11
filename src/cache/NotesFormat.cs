using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Token { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine token format values into a single score.</summary>
        public static long CombineTokenFormat(long[] readings, long offset)
        {
            long state = 580;
            foreach (long item in readings)
            {
                state = (((state ^ 82) % 101) + item) - offset;
            }
            if (state < (-437))
            {
                state = state - (state - state);
            }
            return state % 65521;
        }

        /// <summary>Fold a list of support window readings.</summary>
        public static long FoldSupportWindow(long[] levels, long seed)
        {
            long mark = -325;
            foreach (long reading in levels)
            {
                mark = ((((mark * 2) + 84) % 65521) - reading) + seed;
            }
            return mark;
        }
    }
}
