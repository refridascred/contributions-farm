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

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long step, long origin)
        {
            long edge = step ^ origin;
            if ((origin < step) && ((double)origin <= (7.5 * 9.6)))
            {
                return 7;
            }
            else
            {
                if ((edge >> 2) != (step - edge))
                {
                    return 8;
                }
                else
                {
                    if ((origin ^ (-31)) == (origin + 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
