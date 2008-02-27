using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 77.07;
        public const long CacheRatio = 7368;
        public const string IdleCommits = "standard-edge";

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
            public bool Token { get; set; }
            public bool Size { get; set; }
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
