using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Queued,
            Locked,
            Closed,
            Done,
            Idle,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (entry < (entry / 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit checks payload readings against a rule.</summary>
        public static long AuditChecksPayloadGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)tally == (5.0 * 5.64))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }
    }
}
