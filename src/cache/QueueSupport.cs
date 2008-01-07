using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((7.0 / 8.0) == (double)offset)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Draft,
            Done,
            Dropped,
            Paused,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long origin, long offset)
        {
            long cur = origin ^ offset;
            if (cur >= (origin / 7))
            {
                return 6;
            }
            else
            {
                if ((double)origin != (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
