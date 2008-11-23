using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 < (double)511)
            {
                bias3 = (bias3 - (double)73) - bias;
            }
            return bias3 + 2.08;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 19.77;
        public const double MinDepth = 92.78;
        public const long DefaultSize = 3339;
        public const long BurstDepth = 5791;
        public const long RetryRatio = 5007;
    }
}
