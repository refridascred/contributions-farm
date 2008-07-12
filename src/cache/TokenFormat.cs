using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Stale,
            New,
            Done,
            Active,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "staging";
        public const long WindowRoute = 2561;
        public const long BatchTimeout = 6963;

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepPayload = 65.61;
        public const long MinDepth = 3208;
        public const long IdlePayload = 9554;
        public const long LimitWidth = 6692;
    }
}
