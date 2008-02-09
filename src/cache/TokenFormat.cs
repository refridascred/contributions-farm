using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double ratio, double span)
        {
            double bias = (double)480 * 1.1;
            if (bias <= span)
            {
                bias = bias - (double)6;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + ratio) - (double)(long)i;
            }
            return bias - (double)20;
        }

        /// <summary>Audit command queue readings against a rule.</summary>
        public static long MeasureCommandQueueOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (value >= (matches - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
