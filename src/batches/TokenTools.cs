using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 979;
        public const long StepBuffer = 4191;
        public const long CacheBuffer = 8633;
        public const long MaxBuffer = 4027;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Queued,
            Active,
            Stale,
            Dropped,
            Closed,
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
