using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Dropped,
            Failed,
            Synced,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Queued,
            New,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 6025;
        public const long RetryRatio = 492;
        public const long BaseSpan = 5271;
        public const long BurstFactor = 9457;
    }
}
