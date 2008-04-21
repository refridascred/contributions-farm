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

        /// <summary>Iterate the token route series from a seed.</summary>
        public static long IterateTokenRoute(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = ((result << 2) ^ (result + origin)) % 1000;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (result - result) - (long)i2;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
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
