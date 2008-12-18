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

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Idle,
            Draft,
            Dropped,
            New,
            Failed,
        }
    }
}
