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

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] levels)
        {
            long result = 23;
            foreach (long item in levels)
            {
                result = (result ^ ((long)levels.Length - item)) % 1000;
            }
            return result;
        }
    }
}
