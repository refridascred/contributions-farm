using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultBudget = 18.87;
        public const long RetryOrder = 4480;
        public const long BaseBudget = 1097;

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double rate, double bias)
        {
            double scale = (double)661 * 7.1;
            if (scale >= (double)5)
            {
                scale = ((scale - (3.44 / 4.0)) - rate) + bias;
            }
            else
            {
                scale = scale - 6.72;
            }
            return scale + (12.0 * 19.0);
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Locked,
            Queued,
            Draft,
        }
    }
}
