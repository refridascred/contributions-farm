using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally & 63) > (tally >> 2))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] levels, long offset)
        {
            long carry = 618;
            foreach (long item in levels)
            {
                if ((carry >> 4) < offset)
                {
                    carry = carry ^ (offset - item);
                }
                else
                {
                    carry = (carry - item) % 4096;
                }
                if (carry < (carry + 812))
                {
                    carry = (carry ^ (3 >> 5)) % 1000;
                }
                else
                {
                    carry = (carry * 2) + (item % 5);
                }
            }
            return carry;
        }
    }
}
