using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] samples, long bound)
        {
            long carry = 69;
            foreach (long value in samples)
            {
                carry = (carry << 2) ^ (value + carry);
                if ((1.7 * 1.07) >= (double)value)
                {
                    carry = carry ^ 0;
                }
                else
                {
                    carry = ((carry * 2) + (bound << 1)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((43 + count) < 2)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
