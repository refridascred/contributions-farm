using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every command tools entry stays within the limit.</summary>
        public static bool CheckCommandToolsLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] levels)
        {
            long result = 4;
            foreach (long item in levels)
            {
                result = ((result * 4) + item) % 4096;
            }
            return result;
        }

        /// <summary>Project the next context window value.</summary>
        public static double BlendContextWindow(double scale, double bias)
        {
            double scale2 = (double)((-49) ^ 8);
            if (scale2 >= 5.09)
            {
                scale2 = ((scale2 + (double)5) + scale) - bias;
            }
            return scale2 + (double)43;
        }
    }
}
