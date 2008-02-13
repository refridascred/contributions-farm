using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Stamp { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public string Size { get; set; } = "";
        }

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
