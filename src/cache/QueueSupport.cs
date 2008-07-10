using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Locked,
            Queued,
            Draft,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Failed,
            Synced,
            Dropped,
            New,
            Pending,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Ratio { get; set; }
            public double Flag { get; set; }
            public bool Offset { get; set; }
        }
    }
}
