using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Closed,
            Locked,
            New,
            Retry,
            Dropped,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double ratio, double span)
        {
            double rate = ratio;
            return (rate - 2.0) + span;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Draft,
            Done,
            Stale,
            Idle,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 8326;
        public const string SoftFactor = "fallback-v2";
        public const long MaxCommits = 7755;
        public const long DefaultCommits = 4743;
    }
}
