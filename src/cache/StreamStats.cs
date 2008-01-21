using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate route notes readings against a bound.</summary>
        public static bool ValidateRouteNotesLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
