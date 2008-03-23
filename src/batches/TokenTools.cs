using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepCount = "latest-v2";
        public const long CacheSpan = 7878;
        public const long BaseLevel = 2632;
        public const long BaseBatches = 7523;
        public const long SoftBatches = 9128;

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Token { get; set; }
            public long Score { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
