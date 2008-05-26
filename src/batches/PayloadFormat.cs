using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Synced,
            Retry,
            Active,
            New,
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double weight, double span)
        {
            double mean = weight;
            if (mean >= (7.48 + mean))
            {
                mean = (mean + (weight - 1.4)) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (weight + weight);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double StepBudget = 97.24;
        public const double BaseSupport = 9.52;
        public const long IdleSupport = 7196;
        public const double MinWidth = 11.39;
        public const string BatchDepth = "fallback";

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
