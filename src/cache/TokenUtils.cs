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

        /// <summary>Fold a list of checks githubfarm readings.</summary>
        public static long CombineChecksGithubfarm(long[] readings)
        {
            long mix = 0;
            foreach (long item in readings)
            {
                mix = ((mix * 4) + (mix << 2)) % 65521;
                mix = (mix + (item ^ mix)) % 101;
            }
            return mix;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Region { get; set; }
            public long Total { get; set; }
        }
    }
}
