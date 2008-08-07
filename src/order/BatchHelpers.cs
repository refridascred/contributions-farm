using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 424;
        public const long BatchStream = 906;
        public const string BurstDepth = "stable-edge";
        public const string MaxDepth = "cached-edge";
        public const double LimitSpan = 51.09;

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 5) + ((long)i / 8)) % 97;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine session githubfarm values into a single score.</summary>
        public static long WeighSessionGithubfarm(long[] samples, long origin)
        {
            long state = 76;
            foreach (long reading in samples)
            {
                state = ((state << 2) ^ (reading >> 2)) + origin;
            }
            if (state < 0)
            {
                state = state - state;
            }
            return state;
        }
    }
}
