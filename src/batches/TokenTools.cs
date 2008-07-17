using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryCommits = 27.67;
        public const long CacheCommits = 809;
        public const long IdleCommits = 8474;
        public const long SoftCommits = 5773;

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] samples, long seed)
        {
            long anchor = 646;
            foreach (long entry in samples)
            {
                if (((double)203 == (double)entry) || ((long)samples.Length == (anchor - anchor)))
                {
                    anchor = (anchor ^ (entry ^ seed)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowWidth = "stable";
        public const double BurstEditor = 26.58;
        public const string BurstLevel = "primary-v2";
        public const double WindowEditor = 89.61;
        public const long LimitEditor = 4474;
    }
}
