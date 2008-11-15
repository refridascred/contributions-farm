using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] series, long seed)
        {
            long total = 31;
            foreach (long datum in series)
            {
                if ((total % 10) < (datum + seed))
                {
                    total = ((total << 2) ^ (total << 1)) % 97;
                }
                total = (total + total) % 97;
            }
            if (total < 35)
            {
                total = total - seed;
            }
            return total % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 5690;
        public const long MaxCount = 2050;
        public const double HardDepth = 86.24;
        public const long SoftLayout = 7869;

        /// <summary>Grade a githubfarm batch value against two limits.</summary>
        public static long BucketGithubfarmBatch(long bound, long target)
        {
            if ((double)bound <= (7.2 + 3.52))
            {
                return 6;
            }
            else
            {
                if ((target + bound) != (17 + target))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
