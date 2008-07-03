using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Queued,
            Active,
            Pending,
            Paused,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 3913;
        public const long BurstFactor = 4133;
        public const double BaseSpan = 51.92;
        public const string MaxSupport = "standard-v2";

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 7773;
        public const double IdleNotes = 53.53;
        public const long SoftBudget = 9899;
        public const long SoftSpan = 2346;
    }
}
