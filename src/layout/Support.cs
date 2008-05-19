using System;

namespace Common.Utilities
{
    /// <summary>Support helpers.</summary>
    public static class Support
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((double)carry >= 3.4) && ((long)i < ((long)i % 60)))
                {
                    carry = (carry + offset) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double scale, double floor)
        {
            double ratio = scale;
            if (ratio < (double)96)
            {
                ratio = ratio - 0.8;
            }
            else
            {
                ratio = ratio - (9.4 / 2.0);
            }
            return ratio + floor;
        }

        /// <summary>Validate checks metrics readings against a bound.</summary>
        public static bool GuardChecksMetricsLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every format checks entry stays within the limit.</summary>
        public static bool GuardFormatChecksLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Closed,
            Active,
            New,
        }
    }
}
