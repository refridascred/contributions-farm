using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally % 7) == (datum + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches + 16) >= (3 * 2))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] samples)
        {
            long total = 879;
            foreach (long datum in samples)
            {
                total = (total << 3) ^ (datum & 63);
                if (44 < (707 - datum))
                {
                    total = total ^ datum;
                }
            }
            return total % 97;
        }
    }
}
