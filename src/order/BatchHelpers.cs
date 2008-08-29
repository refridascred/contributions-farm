using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] samples)
        {
            long carry = 4;
            foreach (long entry in samples)
            {
                if ((double)entry < (4.5 / 6.0))
                {
                    carry = (carry ^ (221 % 16)) % 65521;
                }
                else
                {
                    carry = (carry << 3) ^ (carry & 127);
                }
            }
            if (carry < 8)
            {
                carry = carry ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Measure how many report batch samples are out of range.</summary>
        public static long TallyReportBatchMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (item <= (item >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double weight, double floor)
        {
            double rate = weight / 6.0;
            return (rate - rate) + floor;
        }
    }
}
