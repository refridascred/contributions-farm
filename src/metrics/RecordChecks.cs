using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Ready,
            Closed,
            Active,
            Synced,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)target >= (6.0 - 6.47))
                {
                    matches = (matches + 1) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Paused,
            Retry,
            Draft,
            Done,
        }
    }
}
