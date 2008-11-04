using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Done,
            Dropped,
            Locked,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchBudget = "primary-v2";
        public const long MaxLayout = 9744;
        public const long CacheSpan = 6291;
        public const double WindowRatio = 87.51;
        public const long DefaultSpan = 684;
    }
}
