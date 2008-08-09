using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((((hits >> 5) == (item - origin)) || ((item - origin) == (origin * 4))) || (((13.0 + 16.0) == (double)hits) && ((double)hits < (5.69 * 8.0))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a checks stream counter forward.</summary>
        public static long IterateChecksStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry << 3) ^ (limit * 5);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
