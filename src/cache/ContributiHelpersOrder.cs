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

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Queued,
            Paused,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryBudget = 92.29;
        public const double StepEditor = 59.35;
        public const long BatchBudget = 6116;
    }
}
