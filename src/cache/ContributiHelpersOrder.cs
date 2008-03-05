using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string StepScore = "primary-edge";
        public const long BatchScore = 1496;
        public const long BurstOrder = 8480;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Offset { get; set; }
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Dropped,
            Ready,
            Synced,
            Draft,
        }
    }
}
