using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 37.69;
        public const double MaxContributi = 19.1;
        public const long SoftBudget = 3054;

        /// <summary>Define order limits and defaults.</summary>
        public const string MaxOrder = "legacy-1";
        public const string LimitOrder = "strict-edge";
        public const long MinTimeout = 4444;
        public const long BurstOrder = 5397;

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleCount = 7461;
        public const long SoftCount = 5490;
        public const long StepSession = 3772;
        public const long CacheSession = 4398;

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleLevel = 8918;
        public const double LimitRatio = 1.04;
        public const long SoftEntry = 9665;
        public const string BurstLevel = "strict";
        public const long WindowScore = 4375;

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double gain, double floor)
        {
            double bias = (double)(-4) / 7.0;
            if (bias <= (4.45 - floor))
            {
                bias = bias - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias - (gain - floor);
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Pending,
            New,
            Queued,
            Failed,
            Synced,
        }
    }
}
