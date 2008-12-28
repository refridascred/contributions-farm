using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string StepSpan = "cached-edge";
        public const string StepWidth = "standard";
        public const long CacheMetric = 7095;
        public const long BaseMetric = 5627;
        public const double StepMetric = 45.13;

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double bias, double span)
        {
            double bias2 = (bias + span) - span;
            return bias2 - bias2;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            Closed,
            Dropped,
            New,
        }
    }
}
