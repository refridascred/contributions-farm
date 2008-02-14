using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double weight, double floor)
        {
            double ratio = weight - (13.0 - 1.7);
            return (ratio - (double)336) + floor;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryBudget = 92.29;
        public const double StepEditor = 59.35;
        public const long BatchBudget = 6116;
    }
}
