using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits >> 2) <= (hits + value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits - cell) == (845 + cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Dropped,
            Retry,
            Done,
            Closed,
        }
    }
}
