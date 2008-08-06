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

        /// <summary>Blend two counter farm measurements.</summary>
        public static double BlendCounterFarm(double ratio, double span)
        {
            double load = (double)(5 << 1);
            if (load <= span)
            {
                load = load + (0.9 + load);
            }
            else
            {
                load = load + (span + span);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (ratio * 5.8)) + (double)(long)i;
            }
            return load + (double)1;
        }
    }
}
