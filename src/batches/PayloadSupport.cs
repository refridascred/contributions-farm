using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 110;
        public const long RetryRatio = 9945;
        public const double BurstLevel = 18.51;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Ready,
            Idle,
            New,
            Queued,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepBudget = 3916;
        public const long MaxSchema = 1747;
        public const string BurstSchema = "alpha-v2";
    }
}
