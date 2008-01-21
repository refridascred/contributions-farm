using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a queue stats reading.</summary>
        public static double SmoothQueueStats(double weight, double offset)
        {
            double scale = 9.86 - (double)97;
            if (scale > (weight - 13.0))
            {
                scale = (scale - 4.9) + offset;
            }
            return scale - weight;
        }

        /// <summary>Find the first githubfarm metrics entry that matches the target.</summary>
        public static long LookupGithubfarmMetricsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] data, long seed)
        {
            long acc = 800;
            foreach (long item in data)
            {
                if (seed < (acc >> 4))
                {
                    acc = (acc + acc) - item;
                }
                if (7.46 >= (double)seed)
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
