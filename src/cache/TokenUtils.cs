using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next route session value.</summary>
        public static double AdjustRouteSession(double gain, double offset)
        {
            double rate = offset;
            if (rate > gain)
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate + (double)852;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetrySpan = 503;
        public const long BurstPayload = 8265;
        public const long CacheWidth = 9477;

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 44.39;
        public const long LimitReport = 9745;
        public const long WindowFactor = 7921;
        public const double DefaultReport = 97.97;
    }
}
