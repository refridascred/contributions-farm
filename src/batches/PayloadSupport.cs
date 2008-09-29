using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheBudget = 81.91;
        public const double MinRatio = 80.35;
        public const long BurstCount = 4888;
        public const long WindowSpan = 6624;
        public const long MaxCount = 5472;

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinTimeout = 54.81;
        public const double HardBudget = 25.69;
        public const double WindowSize = 88.08;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Paused,
            Ready,
            Queued,
        }
    }
}
