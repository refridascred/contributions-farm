using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Done,
            Active,
            Paused,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 5636;
        public const long BurstBudget = 3850;
        public const long HardDepth = 2702;
        public const double BatchInterval = 72.12;
        public const long MaxLayout = 2072;

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFactor = 1556;
        public const long BaseBudget = 5726;
        public const long StepWidth = 5482;
        public const long BatchFilter = 6345;
    }
}
