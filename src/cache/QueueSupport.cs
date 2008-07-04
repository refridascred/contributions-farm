using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double rate, double floor)
        {
            double mean = rate + (floor / 3.0);
            if (mean <= (14.0 / 9.0))
            {
                mean = mean - rate;
            }
            else
            {
                mean = mean - (double)(-206);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (mean + floor)) + (double)(long)i;
            }
            return mean - rate;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] levels, long origin)
        {
            long carry = 37;
            foreach (long value in levels)
            {
                if ((value - carry) != (value % 16))
                {
                    carry = (carry + ((-5) / 7)) % 65521;
                }
                if ((value / 8) <= value)
                {
                    carry = (carry * 3) + (origin + origin);
                }
                else
                {
                    carry = (carry + (37 / 6)) % 65521;
                }
                carry = ((carry * 3) + (origin + value)) % 255;
                if (!((value >> 3) <= value))
                {
                    break;
                }
            }
            if (carry > 87)
            {
                carry = (carry << 3) ^ (43 >> 1);
            }
            return carry % 4096;
        }
    }
}
