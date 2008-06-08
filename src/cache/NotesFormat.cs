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

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
