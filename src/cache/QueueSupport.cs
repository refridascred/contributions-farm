using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitLevel = 2939;
        public const long BaseScore = 8878;
        public const double CacheCluster = 10.08;

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        matches = matches + 1;
                    }
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
