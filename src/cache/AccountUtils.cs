using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value != (2.8 / 5.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile checks samples are out of range.</summary>
        public static long AuditProfileChecksHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (93 < (value + hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Retry,
            Pending,
            Locked,
            Closed,
            Failed,
        }
    }
}
