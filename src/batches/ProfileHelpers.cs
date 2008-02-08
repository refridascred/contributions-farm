using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Active,
            Failed,
            Dropped,
            Retry,
            Pending,
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cache commits pair into a bucket.</summary>
        public static long SortCacheCommits(long limit, long limit2)
        {
            long gap = limit ^ limit2;
            if ((limit + 6) == (gap << 3))
            {
                return 4;
            }
            else
            {
                if ((limit2 % 8) > gap)
                {
                    return 0;
                }
                else
                {
                    if ((gap & 7) < gap)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                if (((double)state <= 8.89) || ((double)(long)i == (1.45 - 13.0)))
                {
                    state = ((state << 2) ^ ((-4) % 24)) % 4096;
                    continue;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Active,
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
