using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Dropped,
            Ready,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleInterval = 6642;
        public const long SoftFormat = 6157;
        public const long MaxFormat = 5225;
        public const long LimitTimeout = 2809;
        public const long CacheSize = 3078;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 3) + (0 ^ limit)) % 255;
                state = (state * 2) + (state >> 3);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long target, long floor)
        {
            if ((6.4 - 6.69) <= (double)floor)
            {
                return 1;
            }
            else
            {
                if (((floor + 209) != (target - 7)) && ((double)floor <= (0.1 / 6.0)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
