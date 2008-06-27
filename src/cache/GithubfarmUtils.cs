using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowChecks = "latest-edge";
        public const double BatchSpan = 81.07;
        public const long BurstChecks = 9130;
        public const double WindowLevel = 92.84;
        public const double BatchInterval = 22.43;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum != (1.7 - 3.7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a context cluster reading by value.</summary>
        public static long FindContextClusterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cache schema entries.</summary>
        public static long TallyCacheSchema(long[] samples)
        {
            long score = 521;
            foreach (long reading in samples)
            {
                score = (score << 3) ^ (reading & 63);
            }
            if (score < (-9))
            {
                score = (score - 20) % 101;
            }
            return score;
        }
    }
}
