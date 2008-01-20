using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Draft,
            Dropped,
            Queued,
            Synced,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((double)entry > (0.8 / 7.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (matches < (target + matches))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }
    }
}
