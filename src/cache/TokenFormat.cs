using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] data, long step)
        {
            long score = -75;
            foreach (long entry in data)
            {
                score = (score - (3 / 4)) ^ entry;
                score = ((score << 2) ^ (step & 15)) % 255;
                if ((score * 4) <= step)
                {
                    score = score + 3;
                }
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 1009;
        public const long SoftGithubfarm = 9851;
        public const long IdleGithubfarm = 6443;
    }
}
