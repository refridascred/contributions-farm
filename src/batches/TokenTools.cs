using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Owner { get; set; }
            public double Stamp { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Ready,
            Draft,
            Paused,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftFactor = 8966;
        public const long StepEntry = 4921;
        public const long RetryEntry = 7079;
    }
}
