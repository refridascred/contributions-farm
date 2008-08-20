using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long seed, long seed2)
        {
            if ((seed ^ seed2) >= seed)
            {
                return 6;
            }
            else
            {
                if (!((seed >> 1) != (seed2 - seed2)))
                {
                    return 1;
                }
                else
                {
                    if ((seed2 / 9) >= seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(14.0 <= (double)seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
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
