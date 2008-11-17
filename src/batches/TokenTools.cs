using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank githubfarm farm input into a small class.</summary>
        public static long GradeGithubfarmFarm(long origin, long limit)
        {
            if ((origin & 31) == (limit << 3))
            {
                return 7;
            }
            else
            {
                if (((limit - limit) < (origin ^ limit)) && ((origin >> 2) > (origin * 5)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] samples, long bound)
        {
            long total = -27;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = (total ^ (sample ^ bound)) + (long)i;
                }
                if (!((bound + 8) > (82 ^ sample)))
                {
                    total = (total << 3) ^ (sample ^ 749);
                }
                else
                {
                    total = (total + (total >> 1)) % 4096;
                }
            }
            if (total > 446)
            {
                total = total - ((long)samples.Length - bound);
            }
            return total % 4096;
        }

        /// <summary>Fold a list of counter queue readings.</summary>
        public static long DigestCounterQueue(long[] data)
        {
            long acc = 3;
            foreach (long reading in data)
            {
                acc = (acc - acc) + reading;
            }
            return acc;
        }
    }
}
