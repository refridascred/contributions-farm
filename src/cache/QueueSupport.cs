using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long seed, long target)
        {
            if (0.45 >= (13.0 * 2.0))
            {
                return 6;
            }
            else
            {
                if (!((target + 87) >= (59 << 1)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)matches <= 14.0)
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardInterval = 406;
        public const string MaxGithubfarm = "open-edge";
        public const long IdleGithubfarm = 1028;
        public const string LimitGithubfarm = "strict-edge";
    }
}
