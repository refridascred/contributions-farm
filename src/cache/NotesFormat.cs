using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitScore = 1968;
        public const long IdleRatio = 474;
        public const long WindowSpan = 1207;
        public const string HardPayload = "latest-v2";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheTimeout = 3387;
        public const string BatchCluster = "latest";
        public const long StepScore = 1124;
        public const string DefaultDepth = "cached-v2";
        public const string MaxLevel = "staging-edge";
    }
}
