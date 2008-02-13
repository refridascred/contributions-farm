using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSpan = "cached-edge";
        public const long BurstFactor = 8142;
        public const long MaxDepth = 3460;
        public const long BaseDepth = 168;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Size { get; set; }
            public bool Token { get; set; }
            public string Mode { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            New,
            Paused,
            Pending,
            Synced,
        }
    }
}
