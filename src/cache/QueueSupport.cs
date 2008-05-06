using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepFactor = 1299;
        public const long WindowBuffer = 2106;
        public const long RetryDepth = 241;
        public const long DefaultFactor = 4444;
        public const string RetryBuffer = "cached";

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftSize = 5512;
        public const long BurstContext = 6984;
        public const long WindowContext = 108;
        public const long IdleContext = 5293;
    }
}
