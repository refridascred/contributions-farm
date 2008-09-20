using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitTimeout = 1263;
        public const long StepWidth = 17;
        public const double MaxCounter = 8.47;
        public const double BaseTimeout = 72.53;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            New,
            Queued,
            Active,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Synced,
            Ready,
            Failed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchScore = 3.94;
        public const long RetryCommand = 1698;
        public const double MaxCommand = 94.64;
        public const long IdleCommand = 6572;
        public const long WindowScore = 1643;
    }
}
