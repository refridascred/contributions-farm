using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Idle,
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Synced,
            Failed,
            Queued,
            New,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "local-v2";
        public const string DefaultCache = "stable-v2";
        public const double BatchCache = 96.41;
    }
}
