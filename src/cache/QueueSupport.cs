using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit counter commits readings against a rule.</summary>
        public static long AuditCounterCommitsGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((1 % 16) <= datum) || ((count & 255) >= (count - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            New,
            Dropped,
            Active,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample <= 5.0))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }
    }
}
