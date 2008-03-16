using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit githubfarm schema readings against a rule.</summary>
        public static long CountGithubfarmSchemaGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample - count) <= (sample - sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long seed, long seed2)
        {
            long delta = seed + seed2;
            if ((double)delta < (6.32 + 2.0))
            {
                return 6;
            }
            else
            {
                if (!((seed2 - seed) != (7 - 39)))
                {
                    return 2;
                }
                else
                {
                    if (((17.0 - 1.96) == (double)seed2) || ((seed2 - seed2) != (delta >> 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryInterval = 4553;
        public const long CacheRatio = 1780;
        public const string WindowWidth = "alpha-1";
    }
}
