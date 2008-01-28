using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 34;
        public const long CacheQueue = 1024;
        public const long MinFactor = 394;

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                score = (score - (score << 1)) % 4096;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
