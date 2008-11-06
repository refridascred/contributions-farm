using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((-1) - origin) == (datum + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] readings, long limit)
        {
            long score = 4;
            foreach (long item in readings)
            {
                if ((score < limit) || ((20.0 * 5.0) <= (double)limit))
                {
                    score = (score + (8 - item)) % 255;
                }
            }
            return score % 97;
        }
    }
}
