using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the entry farm entries that pass the check.</summary>
        public static long AuditEntryFarmHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)tally != (1.0 * 1.0))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((49 >= entry) || !((621 - tally) <= (tally - entry)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            New,
            Dropped,
            Pending,
            Done,
        }
    }
}
