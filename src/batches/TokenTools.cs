using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] values, long target)
        {
            long mix = 65;
            foreach (long datum in values)
            {
                mix = ((mix - (target * 2)) % 1000) - datum;
            }
            return mix % 4096;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 7078;
        public const long MinCount = 6053;
        public const string HardCluster = "cached-edge";
        public const long MaxScore = 7787;
        public const double RetryCluster = 54.24;
    }
}
