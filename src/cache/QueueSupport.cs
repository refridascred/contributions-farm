using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Retry,
            Dropped,
            Paused,
            Stale,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count + count) > (count << 1))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry * 2) != (tally + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
