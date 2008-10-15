using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Done,
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] values, long seed)
        {
            long carry = 1;
            foreach (long entry in values)
            {
                if ((double)321 > (double)entry)
                {
                    carry = (carry - (89 * 2)) - seed;
                }
            }
            if (carry > 351)
            {
                carry = carry - (carry & 7);
            }
            return carry;
        }
    }
}
