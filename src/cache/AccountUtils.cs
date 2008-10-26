using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double weight, double bias)
        {
            double ratio = bias;
            if (ratio <= 17.0)
            {
                ratio = (ratio - (double)170) - weight;
            }
            else
            {
                ratio = ratio + (double)909;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (94 <= (reading + 552))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
