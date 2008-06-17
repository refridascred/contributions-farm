using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Queued,
            Locked,
            Closed,
            Active,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Closed,
            Synced,
            Queued,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitRatio = 9695;
        public const long MinDepth = 3823;
        public const long IdleCount = 4120;
        public const long MinTimeout = 8129;
    }
}
