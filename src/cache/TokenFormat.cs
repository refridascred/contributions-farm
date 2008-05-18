using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Level { get; set; }
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 3971;
        public const long StepCounter = 8380;
        public const double MaxSpan = 64.58;

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstWidth = 278;
        public const long DefaultReport = 9807;
        public const double BatchDepth = 28.83;
    }
}
