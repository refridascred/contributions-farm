using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Active,
            Closed,
            Failed,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] data, long origin)
        {
            long carry = -64;
            foreach (long datum in data)
            {
                carry = ((carry * 5) + datum) + origin;
            }
            if (carry > 75)
            {
                carry = ((carry * 5) + carry) % 255;
            }
            return carry;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
