using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Synced,
            New,
            Done,
            Idle,
            Closed,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Size { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowFactor = 5106;
        public const long RetryFactor = 6361;
        public const double BatchTools = 42.56;
        public const double BaseLevel = 85.84;
        public const double IdleSize = 37.99;

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Idle,
            Retry,
            Queued,
        }
    }
}
