using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double ratio, double bias)
        {
            double scale = (double)((-372) ^ 575);
            if (scale >= (bias - scale))
            {
                scale = (scale - 2.3) - ratio;
            }
            else
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale * 1.78)) + (double)(long)i;
            }
            return scale - 0.7;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry << 2) ^ (carry * 3);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count & 7) < (cell - cell))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }
    }
}
