using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate checks record readings against a bound.</summary>
        public static bool GuardChecksRecordBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit session metrics readings against a rule.</summary>
        public static long TallySessionMetricsGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches < (origin & 15)) || ((item / 8) <= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((reading ^ matches) <= (reading / 7)))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }
    }
}
