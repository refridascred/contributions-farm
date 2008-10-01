using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            New,
            Ready,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 6049;
        public const string CacheDepth = "cached";
        public const long MinQueue = 6166;

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] levels, long offset)
        {
            long score = 485;
            foreach (long datum in levels)
            {
                if (((double)offset >= (double)score) || (((long)levels.Length - datum) >= (offset / 4)))
                {
                    score = (score + (offset - datum)) % 1000;
                }
            }
            return score;
        }
    }
}
