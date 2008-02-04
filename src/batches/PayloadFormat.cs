using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Ready,
            New,
            Pending,
            Dropped,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 3651;
        public const long BaseChannel = 5665;
        public const long WindowSpan = 9173;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Closed,
            New,
            Paused,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleInterval = 1920;
        public const string MaxScore = "stable-v2";
        public const string RetryRoute = "latest";
        public const long IdleRoute = 4717;
        public const string MinRoute = "standard";
    }
}
