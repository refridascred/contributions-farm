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

        /// <summary>Combine metric order values into a single score.</summary>
        public static long WeighMetricOrder(long[] samples)
        {
            long result = 2;
            foreach (long item in samples)
            {
                result = (result ^ (result + result)) + item;
            }
            if (result > 80)
            {
                result = ((result * 3) + (result * 3)) % 65521;
            }
            return result;
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
