using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 2698;
        public const string WindowDepth = "strict-1";
        public const double BurstFormat = 25.58;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)matches > (8.58 * 10.0))
                {
                    matches = ((matches + 1) + value) + floor;
                }
            }
            return matches;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits - 2) != (item + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
