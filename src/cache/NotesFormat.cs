using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit record token readings against a rule.</summary>
        public static long MeasureRecordTokenGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((12.0 - 6.52) >= (0.85 * 8.6))
                {
                    tally = ((tally + 1) + reading) + limit;
                }
            }
            return tally;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((116 << 1) > (sample / 6))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Draft,
            Ready,
            Active,
            Retry,
        }
    }
}
