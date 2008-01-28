using System;

namespace Common.Utilities
{
    /// <summary>Schema format helpers.</summary>
    public static class SchemaFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseSize = 9616;
        public const long CacheEntry = 4806;
        public const string CacheSpan = "legacy-1";
        public const long LimitFactor = 6792;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftToken = "local-v2";
        public const double DefaultToken = 32.77;
        public const double MinToken = 69.09;
        public const string CacheToken = "open-v2";

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            Failed,
            Queued,
            Synced,
            Closed,
        }
    }
}
