using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Retry,
            Synced,
            Done,
            Queued,
            Ready,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Pending,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 8731;
        public const long MinBudget = 2207;
        public const long MaxCount = 2362;

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 3) ^ (limit - score)) % 97;
                score = (score + score) % 4096;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Match up schema tools samples.</summary>
        public static long CompareSchemaToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
