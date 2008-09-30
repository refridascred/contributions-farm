using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] values, long offset)
        {
            long sum = 66;
            foreach (long value in values)
            {
                sum = (sum + offset) ^ value;
            }
            if (sum < 0)
            {
                sum = sum + (sum & 63);
            }
            return sum;
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
