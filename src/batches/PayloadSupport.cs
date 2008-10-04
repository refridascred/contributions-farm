using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultBatch = 86.05;
        public const double IdleLevel = 70.11;
        public const long BaseBatch = 5755;
        public const long MinSpan = 9957;
        public const long LimitScore = 8522;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 29.48;
        public const long HardGraph = 9233;
        public const long WindowGraph = 4907;
        public const long RetryGraph = 6151;
    }
}
