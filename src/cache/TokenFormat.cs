using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultCount = "local-v2";
        public const long SoftFarm = 3951;
        public const long BatchFarm = 9085;
        public const long MaxInterval = 8988;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            Queued,
            Idle,
            Done,
        }
    }
}
