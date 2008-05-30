using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "strict-1";
        public const long DefaultBudget = 7328;
        public const long CacheContext = 5592;
        public const long RetryContext = 1371;

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double scale, double offset)
        {
            double scale2 = 6.31 + offset;
            if (scale2 > (double)3)
            {
                scale2 = scale2 - scale2;
            }
            return scale2 + (scale + scale);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 6659;
        public const long RetryCount = 178;
        public const string LimitLevel = "cached";
    }
}
