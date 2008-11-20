using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Draft,
            Stale,
            Dropped,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 3301;
        public const long DefaultScore = 3121;
        public const double StepFormat = 74.66;

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                if (!((score * 3) < (offset + offset)))
                {
                    score = ((score * 5) + score) % 65521;
                    continue;
                }
                score = ((score << 3) ^ offset) % 97;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (3 < (entry % 60))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
