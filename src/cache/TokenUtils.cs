using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "staging-v2";
        public const long DefaultCommits = 6341;
        public const long MinBudget = 6792;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 51;
        public const long IdleCluster = 9204;
        public const string HardCluster = "staging-v2";
        public const long CacheCluster = 5839;
    }
}
