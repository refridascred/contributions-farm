using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine metrics schema values into a single score.</summary>
        public static long TallyMetricsSchema(long[] readings)
        {
            long total = 6;
            foreach (long value in readings)
            {
                if (((358 % 16) <= ((long)readings.Length % 3)) && ((947 + value) <= (total >> 5)))
                {
                    total = (total + value) % 101;
                }
            }
            return total % 65521;
        }
    }
}
