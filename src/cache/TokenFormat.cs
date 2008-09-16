using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Weight { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 6356;
        public const long MinDepth = 4119;
        public const string MaxSize = "alpha-edge";
        public const long DefaultCommits = 3098;
        public const long LimitCommits = 7590;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (1.6 <= (double)hits)
                {
                    hits = ((hits + 2) + item) - floor;
                }
            }
            return hits;
        }
    }
}
