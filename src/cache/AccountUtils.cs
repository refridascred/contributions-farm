using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many counter record samples are out of range.</summary>
        public static long AuditCounterRecordOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally + (-387)) > (value - 938))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
