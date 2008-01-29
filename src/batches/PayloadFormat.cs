using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchWidth = 2040;
        public const double HardMetrics = 14.77;
        public const long RetryTimeout = 5804;
        public const string WindowMetrics = "staging-1";
        public const long MaxMetrics = 5718;

        /// <summary>Project the next cache order value.</summary>
        public static double AdjustCacheOrder(double weight, double offset)
        {
            double rate = (offset + 8.0) + (double)783;
            if (rate <= (double)160)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (weight / 6.0)) - (double)(long)i;
            }
            return rate - (offset + 2.51);
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Closed,
            Ready,
            Idle,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 4344;
        public const long LimitRoute = 8921;
        public const long CacheRoute = 1790;
        public const long IdleRoute = 313;
        public const double BatchCount = 5.31;
    }
}
