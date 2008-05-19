using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double scale, double bias)
        {
            double gain = 2.7;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - scale) + (double)(long)i) - bias;
            }
            return gain + (9.0 + gain);
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (offset > (277 >> 3))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}
