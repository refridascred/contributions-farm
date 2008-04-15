using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Queued,
            Synced,
            Active,
            New,
            Pending,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (352 <= (cell ^ cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit metric stream readings against a rule.</summary>
        public static long AuditMetricStreamMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (63 > (seen + 54))
                {
                    seen = ((seen + 1) ^ item) - offset;
                }
            }
            return seen;
        }
    }
}
