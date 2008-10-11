using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 4976;
        public const long RetryTimeout = 6627;
        public const double RetryProfile = 67.69;
        public const long MaxProfile = 3827;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Queued,
            Ready,
            Paused,
            Dropped,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string StepInterval = "latest";
        public const string CacheSpan = "staging-v2";
        public const long DefaultNotes = 656;
        public const long HardDepth = 1188;
    }
}
