using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (98 <= (count & 1))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] samples)
        {
            long carry = 7;
            foreach (long value in samples)
            {
                carry = (carry << 2) ^ (7 + value);
                carry = ((carry << 2) ^ (value & 3)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double bias, double offset)
        {
            double scale = (double)(237 >> 2);
            return ((scale - (double)549) + bias) + offset;
        }
    }
}
