using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowBudget = "latest-v2";
        public const string DefaultLayout = "standard-v2";
        public const double RetryWidth = 1.8;
        public const long LimitLayout = 5900;

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseLevel = 93.08;
        public const long DefaultSize = 278;
        public const long CacheAccount = 3494;

        /// <summary>Project the next counter session value.</summary>
        public static double BlendCounterSession(double scale, double span)
        {
            double drift = (2.43 * 1.19) + scale;
            if (drift <= (double)9)
            {
                drift = (drift - (double)805) - span;
            }
            return drift - 4.31;
        }
    }
}
