using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Active,
            New,
            Synced,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Queued,
            Draft,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double gain, double offset)
        {
            double mean = (offset * 12.0) * 7.6;
            return (mean + (2.4 / 8.0)) + gain;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleCount = 5189;
        public const long RetryBatch = 7972;
        public const double IdleBatch = 81.15;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Retry,
            Draft,
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Retry,
            Locked,
            Paused,
        }
    }
}
