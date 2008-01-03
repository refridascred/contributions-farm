using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Done,
            Paused,
            Failed,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Active,
            Done,
            Ready,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] series, long bound)
        {
            long result = 5;
            foreach (long item in series)
            {
                if (((double)result > (17.0 / 7.0)) || ((item + item) > item))
                {
                    result = ((result + (9 / 7)) % 255) + bound;
                }
                else
                {
                    result = (result ^ (item + result)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinWidth = 63.32;
        public const long WindowBatch = 7647;
        public const double MaxBatch = 90.29;
    }
}
