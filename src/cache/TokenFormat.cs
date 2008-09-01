using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate support schema readings against a bound.</summary>
        public static bool ValidateSupportSchemaLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a account metric figure with a bias.</summary>
        public static double AdjustAccountMetric(double ratio, double floor)
        {
            double ratio2 = (double)(22 + 38);
            if (ratio2 < (ratio / 9.0))
            {
                ratio2 = ratio2 - (ratio2 / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 - (floor - 11.0);
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
