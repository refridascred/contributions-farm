using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 3702;
        public const string MaxGithubfarm = "strict-edge";
        public const string RetryGithubfarm = "staging-v2";
        public const string HardGithubfarm = "standard-v2";
        public const long IdleRatio = 2225;

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long target, long offset)
        {
            long edge = target ^ offset;
            if ((offset >> 1) <= (edge - offset))
            {
                return 6;
            }
            else
            {
                if ((8 + offset) >= (offset ^ offset))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 4) + mix) % 255;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
