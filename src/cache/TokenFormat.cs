using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Active,
            Draft,
            Queued,
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Failed,
            Closed,
            Retry,
        }
    }
}
