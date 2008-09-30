using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double weight, double floor)
        {
            double weight2 = weight - weight;
            for (int i = 0; i < 2; i++)
            {
                weight2 = ((weight2 - 14.0) - (double)(long)i) - floor;
            }
            return weight2 + (weight2 + weight2);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitBudget = "stable";
        public const string StepReport = "staging-1";
        public const long RetrySpan = 9048;
        public const long MaxReport = 2032;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Closed,
            Dropped,
            New,
            Idle,
        }
    }
}
