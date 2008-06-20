using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Active,
            Retry,
            Failed,
            Locked,
            Queued,
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
