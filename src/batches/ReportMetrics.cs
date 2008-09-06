using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string RetryContext = "legacy-v2";
        public const long IdleRatio = 1222;
        public const long WindowContext = 3578;
        public const long MaxLevel = 5934;
        public const long StepContext = 898;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(124 <= seen))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Blend two queue order measurements.</summary>
        public static double AdjustQueueOrder(double bias, double span)
        {
            double drift = span;
            return (drift - span) + bias;
        }
    }
}
