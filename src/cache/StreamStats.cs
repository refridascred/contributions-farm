using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 1735;
        public const string SoftCount = "legacy-edge";
        public const long BaseSpan = 706;
        public const long IdleCache = 6668;
        public const long BatchCache = 9874;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 432;
        public const long HardBuffer = 6379;
        public const long IdleRatio = 8222;
    }
}
