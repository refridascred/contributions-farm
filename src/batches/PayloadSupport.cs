using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a schema record figure with a bias.</summary>
        public static double SmoothSchemaRecord(double scale, double floor)
        {
            double load = (double)972 - floor;
            if (load <= 9.5)
            {
                load = (load - (12.0 / 2.0)) - scale;
            }
            return load - (floor * 5.07);
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)26 != (double)matches)
                {
                    matches = ((matches + 1) - cell) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Done,
            Synced,
            Draft,
            Active,
        }
    }
}
