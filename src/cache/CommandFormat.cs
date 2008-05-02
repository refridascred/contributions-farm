using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Pending,
            New,
            Queued,
        }

        /// <summary>Digest a series of metrics queue entries.</summary>
        public static long TotalMetricsQueue(long[] readings)
        {
            long carry = -97;
            foreach (long value in readings)
            {
                carry = carry - (value * 5);
                if ((carry + 39) == (value % 97))
                {
                    carry = ((carry * 3) + (value + value)) % 97;
                }
                else
                {
                    carry = (carry ^ (value / 6)) % 4096;
                }
            }
            if (carry > 4)
            {
                carry = carry + carry;
            }
            return carry % 97;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Retry,
            Stale,
            Active,
            Synced,
        }

        /// <summary>Measure how many report format samples are out of range.</summary>
        public static long CountReportFormatGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((19.0 - 7.4) > (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
