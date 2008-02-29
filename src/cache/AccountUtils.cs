using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleRatio = "latest-edge";
        public const long CacheEntry = 3641;
        public const long MaxEntry = 8433;

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCount = 1834;
        public const long WindowScore = 3275;
        public const long IdleCommits = 9915;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Region { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
