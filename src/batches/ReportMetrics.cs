using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] series)
        {
            long carry = 7;
            foreach (long datum in series)
            {
                if ((datum & 15) < (carry + 7))
                {
                    carry = carry + carry;
                }
            }
            if (carry < 84)
            {
                carry = (carry * 3) + carry;
            }
            return carry;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Idle,
            Locked,
        }
    }
}
