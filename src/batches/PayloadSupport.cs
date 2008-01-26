using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Retry,
            New,
            Active,
        }

        /// <summary>Audit buffer batches readings against a rule.</summary>
        public static long AuditBufferBatchesOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((272 + offset) < offset))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((count ^ entry) != (bound + count)) || (((double)entry == (7.93 - 4.6)) || ((entry % 2) >= (bound - bound))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
