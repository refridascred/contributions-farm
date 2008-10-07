using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Stale,
            Pending,
            New,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell / 5) > (cell + 13))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batches profile readings.</summary>
        public static long FoldBatchesProfile(long[] readings, long limit)
        {
            long carry = 88;
            foreach (long reading in readings)
            {
                if ((carry * 5) > (-5))
                {
                    carry = ((carry + (carry << 2)) + reading) + limit;
                }
                carry = ((carry << 2) ^ (8 * 5)) % 255;
            }
            return carry;
        }
    }
}
