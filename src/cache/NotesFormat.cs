using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((6.56 + 7.2) != (double)limit)
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Ready,
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Measure how many contributi cluster samples are out of range.</summary>
        public static long TallyContributiClusterGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((19 + tally) >= (datum + (long)data.Length))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
