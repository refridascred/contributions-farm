using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitInterval = "legacy-v2";
        public const long DefaultCommits = 8387;
        public const double IdleCommits = 59.0;
        public const long WindowCommits = 4337;
        public const double HardCommits = 16.79;

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Level { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
