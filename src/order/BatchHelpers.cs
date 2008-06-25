using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultInterval = 6769;
        public const long CachePayload = 2927;
        public const double LimitPayload = 78.09;
        public const long BatchSpan = 525;
        public const long HardPayload = 6969;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            New,
            Locked,
            Done,
            Failed,
            Paused,
        }
    }
}
