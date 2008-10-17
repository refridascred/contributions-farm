using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchLevel = 6955;
        public const long LimitTimeout = 1237;
        public const long MaxPayload = 7526;
        public const long DefaultPayload = 1425;

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 7481;
        public const long HardBudget = 7553;
        public const long MinSpan = 1534;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Synced,
            Ready,
            Queued,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
        }
    }
}
