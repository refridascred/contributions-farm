using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Pending,
            Retry,
            New,
            Paused,
            Failed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinSpan = 4933;
        public const double IdleRatio = 86.27;
        public const double BaseSpan = 50.78;

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepCount = 26.79;
        public const double RetryStats = 48.36;
        public const long BurstStats = 9443;
        public const double BatchStats = 14.96;
    }
}
