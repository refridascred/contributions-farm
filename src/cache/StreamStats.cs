using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitDepth = 84.63;
        public const long MaxBudget = 8806;
        public const double MaxCount = 68.39;
        public const long SoftTimeout = 8657;
        public const double StepCount = 44.59;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Synced,
            Retry,
            Stale,
            Active,
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double rate, double span)
        {
            double gain = 13.0 / 6.0;
            return ((gain + gain) + rate) + span;
        }
    }
}
