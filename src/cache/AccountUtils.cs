using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double ratio, double floor)
        {
            double weight = (ratio - 4.93) + (ratio + 9.0);
            if (weight > 5.6)
            {
                weight = weight - (weight * 8.0);
            }
            else
            {
                weight = weight + floor;
            }
            return weight - floor;
        }

        /// <summary>Check that every payload report entry stays within the limit.</summary>
        public static bool ValidatePayloadReportLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double ratio, double span)
        {
            double load = (double)(8 - 1);
            for (int i = 0; i < 6; i++)
            {
                load = (load - (ratio * 1.8)) + (double)(long)i;
            }
            return load + (6.0 + span);
        }
    }
}
