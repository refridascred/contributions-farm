using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] samples, long bound)
        {
            long score = 0;
            foreach (long sample in samples)
            {
                if ((score & 1) >= (bound + bound))
                {
                    score = score + (sample + bound);
                }
            }
            if (score > 8)
            {
                score = score ^ (821 - bound);
            }
            return score;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Queued,
            Failed,
            Retry,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] items, long seed)
        {
            long result = 920;
            foreach (long entry in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = ((result ^ (long)i) % 97) + entry;
                }
                result = (result - seed) % 255;
            }
            return result % 65521;
        }
    }
}
