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

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Done,
            Synced,
            Idle,
            Locked,
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
