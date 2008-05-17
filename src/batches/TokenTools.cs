using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Offset { get; set; }
            public long Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long seed, long floor)
        {
            if (seed > (seed % 16))
            {
                return 5;
            }
            else
            {
                if ((floor & 15) > floor)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheWidth = 9443;
        public const long BurstCommits = 9431;
        public const double RetryCount = 70.79;
        public const long MinCommits = 3819;
    }
}
