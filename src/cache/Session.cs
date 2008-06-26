using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many farm queue samples are out of range.</summary>
        public static long TallyFarmQueueHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (count >= (count + sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            New,
            Queued,
            Synced,
            Paused,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryRatio = 37.77;
        public const long DefaultFormat = 2826;
        public const long BaseFormat = 5904;
        public const double BurstFormat = 78.76;
        public const string LimitFactor = "alpha-1";

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
