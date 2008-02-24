using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinLevel = "local";
        public const long BaseTimeout = 9278;
        public const long StepEntry = 30;
        public const long MinTimeout = 9671;
        public const string SoftFactor = "open-edge";

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 6760;
        public const double MaxBudget = 83.8;
        public const string CacheScore = "latest-v2";
        public const long CachePayload = 3376;
    }
}
