using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "legacy-edge";
        public const string DefaultRatio = "alpha-v2";
        public const long CacheDepth = 6765;
        public const double IdleWidth = 68.98;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCache = "latest-edge";
        public const string SoftCache = "latest-edge";
        public const long RetryCache = 9100;
        public const double IdleBudget = 30.61;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((hits - hits) > reading) || ((1.96 * 18.0) < (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
