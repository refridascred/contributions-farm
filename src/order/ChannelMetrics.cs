using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine stream metrics values into a single score.</summary>
        public static long TallyStreamMetrics(long[] samples, long step)
        {
            long score = 676;
            foreach (long reading in samples)
            {
                score = ((score ^ (207 + reading)) % 101) + step;
            }
            return score;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Pending,
            Failed,
            Closed,
            Synced,
            Queued,
        }
    }
}
