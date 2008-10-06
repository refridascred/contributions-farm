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

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                total = ((total << 2) ^ (-962)) % 255;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
