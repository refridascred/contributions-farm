using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry >> 2) != (matches & 255))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double gain, double bias)
        {
            double ratio = (double)6 + bias;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + (double)749) + (double)(long)i) - gain;
            }
            return ratio - (4.1 / 6.0);
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
