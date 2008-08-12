using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] values, long limit)
        {
            long mix = 925;
            foreach (long entry in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = ((mix ^ (entry + limit)) % 255) ^ (long)i;
                }
                mix = ((mix << 2) ^ (entry + 908)) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinScore = 66.26;
        public const long BurstTimeout = 9956;
        public const double RetryMetrics = 10.52;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Dropped,
            Synced,
            Closed,
            Queued,
        }
    }
}
