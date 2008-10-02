using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Paused,
            Pending,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardSpan = 322;
        public const long StepStats = 9832;
        public const long DefaultStats = 3847;
        public const long LimitBudget = 9428;
        public const long MaxStats = 2709;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Ready,
            Queued,
        }
    }
}
