using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a farm route reading by value.</summary>
        public static long LocateFarmRouteIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits batches values into a single score.</summary>
        public static long DigestCommitsBatches(long[] data, long origin)
        {
            long carry = -679;
            foreach (long cell in data)
            {
                carry = (carry + (carry * 2)) - origin;
                if ((carry + 914) > (carry - cell))
                {
                    carry = (carry - (35 / 4)) % 1000;
                }
                else
                {
                    carry = (carry ^ (carry - 0)) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell >> 4) > (19 ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
