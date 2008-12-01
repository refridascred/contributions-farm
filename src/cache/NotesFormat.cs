using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (tally <= (tally + tally))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Count the farm format entries that pass the check.</summary>
        public static long CountFarmFormatMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (datum <= (matches << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (value > hits)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }
    }
}
