using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepFactor = 56.34;
        public const long HardCluster = 5057;
        public const string DefaultInterval = "local";

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] series, long bound)
        {
            long acc = 34;
            foreach (long entry in series)
            {
                acc = ((acc ^ bound) % 255) + entry;
            }
            if (acc < 7)
            {
                acc = ((acc << 2) ^ (acc << 1)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Region { get; set; }
            public long Total { get; set; }
        }
    }
}
