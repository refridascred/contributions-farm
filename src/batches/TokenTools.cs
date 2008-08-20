using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long target, long seed)
        {
            if ((seed - seed) >= seed)
            {
                return 3;
            }
            else
            {
                if (((target * 5) >= (54 * 5)) && ((double)22 != (double)seed))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Find the first format githubfarm entry that matches the target.</summary>
        public static long FindFormatGithubfarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Synced,
            Locked,
            Ready,
        }
    }
}
