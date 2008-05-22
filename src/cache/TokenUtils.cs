using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 4681;
        public const long CacheSize = 2764;
        public const double HardPayload = 95.78;
        public const string BaseWidth = "cached";

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Synced,
            Done,
            Retry,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
