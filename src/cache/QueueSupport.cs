using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 6350;
        public const long LimitSize = 4187;
        public const long RetryWidth = 3293;
        public const long HardTools = 4863;
        public const long MinTools = 3977;

        /// <summary>Scale a counter buffer figure with a bias.</summary>
        public static double AdjustCounterBuffer(double gain, double bias)
        {
            double drift = 1.0;
            if (drift < (double)14)
            {
                drift = drift + (20.0 * 1.1);
            }
            else
            {
                drift = drift - (bias - drift);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (gain - bias)) + (double)(long)i;
            }
            return drift - (double)431;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double gain, double span)
        {
            double bias = span;
            if (bias > (gain - bias))
            {
                bias = bias - (double)58;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (span + bias)) + (double)(long)i;
            }
            return bias - (double)368;
        }
    }
}
