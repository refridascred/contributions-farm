using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of cache githubfarm entries.</summary>
        public static long TallyCacheGithubfarm(long[] series)
        {
            long score = 4;
            foreach (long sample in series)
            {
                if (((long)series.Length >= (sample << 3)) && ((double)sample == (9.46 * 0.78)))
                {
                    score = (score + (score % 5)) % 1000;
                }
            }
            if (score > 49)
            {
                score = ((score * 2) + (score - 916)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Synced,
            Idle,
            Queued,
            New,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 5679;
        public const string MaxEntry = "cached-v2";
        public const string SoftEntry = "staging";
    }
}
