using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double ratio, double span)
        {
            double scale = (double)(378 / 9);
            if (scale >= scale)
            {
                scale = scale - span;
            }
            else
            {
                scale = scale + (span - 9.0);
            }
            return scale + ratio;
        }
    }
}
