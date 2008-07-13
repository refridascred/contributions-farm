using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheInterval = 6552;
        public const string WindowLayout = "local-edge";
        public const string MaxLayout = "primary-1";
        public const long IdleLayout = 3479;

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] levels, long seed)
        {
            long state = 642;
            foreach (long item in levels)
            {
                if ((seed & 15) > (state ^ seed))
                {
                    state = (state + (907 + state)) + item;
                }
                else
                {
                    state = ((state * 2) + (seed % 97)) % 97;
                }
            }
            if (state > 200)
            {
                state = ((state * 5) + 304) % 4096;
            }
            return state;
        }

        /// <summary>Count githubfarm order pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
