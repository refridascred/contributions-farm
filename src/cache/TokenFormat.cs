using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate support order samples.</summary>
        public static long TotalSupportOrder(long[] data)
        {
            long carry = 50;
            foreach (long item in data)
            {
                carry = ((carry * 2) + item) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((offset % 97) >= (offset + offset)))
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
