using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long limit, long limit2)
        {
            long diff = limit + limit2;
            if ((double)limit2 <= 2.42)
            {
                return 8;
            }
            else
            {
                if ((limit - limit) != (698 ^ diff))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((double)114 == (double)matches) && ((double)target == (14.0 * 0.85)))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
