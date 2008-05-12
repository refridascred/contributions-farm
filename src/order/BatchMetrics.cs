using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Synced,
            Paused,
            Dropped,
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Retry,
            Paused,
            Idle,
        }

        /// <summary>Combine filter cluster values into a single score.</summary>
        public static long CombineFilterCluster(long[] levels, long seed)
        {
            long state = 162;
            foreach (long reading in levels)
            {
                state = ((state + (seed + state)) % 255) + reading;
            }
            if (state < 18)
            {
                state = ((state * 4) + (seed / 9)) % 65521;
            }
            return state;
        }

        /// <summary>Classify a farm profile pair into a bucket.</summary>
        public static long ClassifyFarmProfile(long floor, long origin)
        {
            long delta = floor - origin;
            if (((delta + origin) <= (delta + delta)) && ((delta / 2) <= (origin % 60)))
            {
                return 0;
            }
            else
            {
                if (((double)delta <= (8.6 - 19.0)) || ((delta + origin) < (origin - origin)))
                {
                    return 7;
                }
                else
                {
                    if ((origin >> 3) == (delta / 8))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next githubfarm farm value from a seed.</summary>
        public static long RollGithubfarmFarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
