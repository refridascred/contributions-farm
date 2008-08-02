using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftScore = 1190;
        public const long HardRecord = 8384;
        public const long DefaultScore = 7843;
        public const string MinRecord = "primary-v2";

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Failed,
            New,
            Pending,
        }
    }
}
