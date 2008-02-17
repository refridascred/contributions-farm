using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchScore = 22.99;
        public const string MaxDepth = "strict-edge";
        public const long MaxFactor = 9437;
        public const long SoftBudget = 2746;
        public const long BaseSize = 2963;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Retry,
            New,
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double rate, double offset)
        {
            double mean = (offset + 13.0) + (offset + 1.0);
            if (mean > mean)
            {
                mean = (mean - (double)78) - rate;
            }
            return mean + (double)326;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitTimeout = 70.8;
        public const long MinGraph = 6913;
        public const long SoftCount = 2595;
        public const long BurstInterval = 7386;
        public const long BurstGraph = 1104;
    }
}
