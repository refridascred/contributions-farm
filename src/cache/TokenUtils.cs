using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the token layout entries that pass the check.</summary>
        public static long AuditTokenLayoutGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)hits <= (4.82 / 7.0))
                {
                    hits = ((hits + 1) - cell) - origin;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count - count) <= (768 + count))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Idle,
            Draft,
            Stale,
            Queued,
        }
    }
}
