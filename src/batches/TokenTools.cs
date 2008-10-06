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

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
