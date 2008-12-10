using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double scale, double offset)
        {
            double bias = (scale / 9.0) / 9.0;
            if (bias < (double)86)
            {
                bias = (bias + bias) - offset;
            }
            return bias + (scale / 4.0);
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 7847;
        public const double StepCommand = 2.28;
        public const long LimitCommand = 1591;
        public const long MaxScore = 2729;
    }
}
