using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Paused,
            Closed,
            Pending,
            New,
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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits * 4) >= (cell / 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
