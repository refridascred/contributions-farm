using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double bias, double offset)
        {
            double ratio = offset;
            if (ratio <= 4.9)
            {
                ratio = ratio + 4.6;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (bias * 9.0)) - (double)(long)i;
            }
            return ratio - (ratio / 3.0);
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double gain, double floor)
        {
            double ratio = floor + floor;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + floor) + (double)(long)i) - gain;
            }
            return ratio - (ratio / 7.0);
        }
    }
}
