using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Closed,
            Done,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 7334;
        public const double BatchDepth = 22.24;
        public const string MinWidth = "stable-v2";
        public const long HardBatch = 5106;
        public const long LimitCount = 9506;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((floor * 4) == (reading << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate schema githubfarm readings against a bound.</summary>
        public static bool GuardSchemaGithubfarmLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
