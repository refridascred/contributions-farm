using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] levels, long offset)
        {
            long carry = 19;
            foreach (long datum in levels)
            {
                if ((17 * 2) > carry)
                {
                    carry = (((carry * 3) + (offset * 5)) % 4096) ^ datum;
                }
            }
            if (carry < 172)
            {
                carry = ((carry << 3) ^ (carry - carry)) % 255;
            }
            return carry;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double bias, double offset)
        {
            double bias2 = offset;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 + (offset - 3.8);
        }
    }
}
