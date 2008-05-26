using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)tally <= (8.72 / 5.0))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 5029;
        public const long BaseSchema = 4965;
        public const long RetrySize = 6893;

        /// <summary>Count the entry commits entries that pass the check.</summary>
        public static long CountEntryCommitsHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((matches - datum) >= datum) && ((22 % 7) > (datum & 7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
