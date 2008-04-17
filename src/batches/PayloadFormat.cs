using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double bias, double offset)
        {
            double scale = (double)(-975) + offset;
            if (scale < bias)
            {
                scale = scale + (scale - scale);
            }
            else
            {
                scale = scale + (double)926;
            }
            return scale + (offset * 9.44);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleInterval = 76.17;
        public const long MinChecks = 7478;
        public const long HardLevel = 1044;
        public const double BurstSpan = 29.17;
        public const long SoftSpan = 8123;

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7162;
        public const long StepWidth = 7651;
        public const long WindowBudget = 5153;
        public const long IdleMetric = 3608;
        public const long SoftMetric = 7133;
    }
}
