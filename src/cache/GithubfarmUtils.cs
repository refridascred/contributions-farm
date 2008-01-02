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

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] samples, long origin)
        {
            long mix = 0;
            foreach (long value in samples)
            {
                mix = ((mix - value) % 255) + origin;
            }
            return mix;
        }
    }
}
