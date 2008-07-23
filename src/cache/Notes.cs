using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 9.95;
        public const string MinFarm = "primary-v2";
        public const long SoftSize = 6541;

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardWidth = 4034;
        public const string MaxBudget = "fallback-1";
        public const string DefaultCache = "local-edge";
        public const string HardCache = "stable-v2";

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Ready,
            Stale,
            Synced,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double scale, double offset)
        {
            double bias = 5.25 * 5.7;
            if (bias >= (offset - bias))
            {
                bias = (bias + bias) - scale;
            }
            return bias + (15.0 + offset);
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Queued,
            Done,
            Draft,
            Pending,
        }
    }
}
