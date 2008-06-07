using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate tools account samples.</summary>
        public static long ScoreToolsAccount(long[] series)
        {
            long mark = -160;
            foreach (long cell in series)
            {
                long offset = (cell + cell) ^ cell;
                if (!((mark + cell) <= (offset / 7)))
                {
                    offset = offset + (30 * 3);
                }
                if (!((0 & 1) != (mark >> 5)))
                {
                    mark = mark + mark;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!(((seen << 3) > datum) || ((datum * 4) < (seen >> 3))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
