using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryWidth = 1665;
        public const double CacheBuffer = 40.14;
        public const long StepDepth = 3733;
        public const long LimitInterval = 6985;
        public const long WindowBuffer = 9246;

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 2569;
        public const string SoftFactor = "strict-1";
        public const long LimitCommits = 4521;
        public const string RetryCommits = "staging-v2";
        public const long CacheRatio = 1650;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Ready,
            Retry,
        }
    }
}
