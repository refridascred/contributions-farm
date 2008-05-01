using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftTimeout = 6879;
        public const double SoftMetrics = 52.44;
        public const long LimitBudget = 9649;
        public const double StepMetrics = 20.69;
        public const long HardMetrics = 4584;

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double ratio, double floor)
        {
            double weight = floor;
            if (weight <= floor)
            {
                weight = (weight - weight) + ratio;
            }
            return weight + (double)89;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Synced,
            Closed,
            Failed,
        }
    }
}
