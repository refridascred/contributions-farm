using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Active,
            Draft,
            Queued,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Level { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitRoute = "primary-edge";
        public const double BaseLevel = 58.71;
        public const long IdleRoute = 1883;
        public const double BurstRoute = 45.47;
        public const double StepRoute = 70.76;
    }
}
