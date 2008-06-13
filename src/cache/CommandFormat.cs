using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "latest-v2";
        public const long DefaultQueue = 4597;
        public const long SoftRatio = 466;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Active,
            Synced,
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitFactor = "open-1";
        public const double HardWindow = 21.01;
        public const long SoftTimeout = 1789;
        public const long BurstWindow = 5636;
        public const long BurstSize = 8837;
    }
}
