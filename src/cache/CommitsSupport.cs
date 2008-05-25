using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double StepRoute = 53.69;
        public const long CacheRoute = 840;
        public const long IdleRatio = 1625;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchInterval = 4704;
        public const long SoftWidth = 19;
        public const string RetryFactor = "staging-v2";
        public const string HardMetrics = "staging-1";

        /// <summary>Match up tools contributi samples.</summary>
        public static long OverlapToolsContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count >> 3) < (7 & 3))
                {
                    count = ((count + 3) ^ reading) + target;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string CacheTimeout = "local-edge";
        public const long MinRatio = 4986;
        public const string MinGithubfarm = "standard-v2";

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Dropped,
            Stale,
            Idle,
            Ready,
        }
    }
}
