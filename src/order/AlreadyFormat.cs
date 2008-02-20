using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MinLevel = "local-1";
        public const long StepFormat = 5113;
        public const string CacheFormat = "cached-edge";

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            New,
            Failed,
            Done,
            Pending,
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Ready,
            Draft,
            Done,
        }
    }
}
