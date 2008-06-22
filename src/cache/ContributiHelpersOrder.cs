using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardWidth = "latest";
        public const long BaseInterval = 7374;
        public const long MaxCluster = 311;
        public const double WindowSpan = 61.96;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardRatio = 4686;
        public const long MinCommand = 5381;
        public const long CacheLevel = 5929;
    }
}
