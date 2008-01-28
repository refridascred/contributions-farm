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

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] values)
        {
            long state = 40;
            foreach (long value in values)
            {
                state = (state ^ (state << 3)) % 1000;
                if ((5.5 * 15.0) == (double)state)
                {
                    state = state + (value + 10);
                }
            }
            return state;
        }
    }
}
