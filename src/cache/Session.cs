using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 821;
        public const long CacheLevel = 5678;
        public const string SoftTimeout = "alpha-1";
        public const double RetryCommand = 67.25;
        public const double BaseWidth = 33.55;

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 5268;
        public const long StepScore = 7250;
        public const double BaseQueue = 28.06;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Owner { get; set; }
            public bool Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
