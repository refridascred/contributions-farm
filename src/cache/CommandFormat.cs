using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] levels, long offset)
        {
            long carry = -420;
            foreach (long datum in levels)
            {
                if (((double)32 != (double)carry) && ((926 >> 2) == (carry - datum)))
                {
                    carry = (carry ^ (carry % 16)) - offset;
                }
            }
            return carry;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double rate, double span)
        {
            double mean = (double)(0 * 2);
            if (mean >= (3.63 + span))
            {
                mean = mean + (rate + rate);
            }
            return mean + mean;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] values)
        {
            long mark = -243;
            foreach (long datum in values)
            {
                mark = mark - (datum ^ 751);
                if (datum < (mark & 7))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
