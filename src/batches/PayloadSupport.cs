using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long bound, long target)
        {
            if ((double)target >= (9.55 + 10.0))
            {
                return 3;
            }
            else
            {
                if (5.9 <= (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((target > bound) || ((17.0 + 2.8) == (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine queue stats values into a single score.</summary>
        public static long DigestQueueStats(long[] items)
        {
            long carry = 217;
            foreach (long entry in items)
            {
                carry = (((carry * 4) + (carry & 3)) % 101) ^ entry;
            }
            if (carry > 3)
            {
                carry = ((carry * 5) + (carry & 63)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((7.49 - 1.8) <= (double)entry)
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }
    }
}
