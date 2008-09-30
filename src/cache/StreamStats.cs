using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a token metric reading.</summary>
        public static double SmoothTokenMetric(double ratio, double floor)
        {
            double rate = (ratio / 8.0) * 0.9;
            if (rate >= rate)
            {
                rate = rate + floor;
            }
            else
            {
                rate = rate - (double)1;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (8.04 * 8.7)) + (double)(long)i;
            }
            return rate + (ratio + floor);
        }

        /// <summary>Roll a command report counter forward.</summary>
        public static long StepCommandReport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (carry - ((long)i2 * 2)) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark << 2) ^ (origin * 3)) % 4096;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
