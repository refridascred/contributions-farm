using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepDepth = 4540;
        public const long RetryGithubfarm = 7048;
        public const long LimitScore = 1448;
        public const double LimitGithubfarm = 80.63;

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardSpan = 6340;
        public const double MaxPayload = 26.97;
        public const long MaxInterval = 4431;
        public const long RetryPayload = 9056;
        public const double BatchPayload = 20.29;

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            Failed,
            Retry,
            New,
            Done,
        }
    }
}
