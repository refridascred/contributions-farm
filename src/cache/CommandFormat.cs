using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double scale, double span)
        {
            double scale2 = 8.0 / 8.0;
            if (scale2 >= scale2)
            {
                scale2 = ((scale2 - 13.0) - scale) - span;
            }
            return scale2 + (scale2 - scale2);
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double ratio, double floor)
        {
            double scale = 7.29;
            if (scale < 8.3)
            {
                scale = (scale + ratio) + floor;
            }
            else
            {
                scale = scale + (3.12 * 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (ratio + ratio)) + (double)(long)i;
            }
            return scale - (ratio * 2.3);
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] data, long seed)
        {
            long carry = 597;
            foreach (long sample in data)
            {
                if (((seed * 2) != (carry + seed)) || ((seed - 227) >= seed))
                {
                    carry = (carry * 4) + (seed + 9);
                }
                else
                {
                    carry = (carry * 4) + (seed - seed);
                }
                if ((seed * 3) == (520 - sample))
                {
                    carry = (carry << 3) ^ (1 / 5);
                }
                if ((double)sample != (double)carry)
                {
                    carry = (carry ^ (seed % 16)) % 255;
                }
            }
            return carry;
        }
    }
}
