using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Done,
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally + origin) == (5 << 2))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
