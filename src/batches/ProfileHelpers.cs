using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine session profile values into a single score.</summary>
        public static long TallySessionProfile(long[] levels, long target)
        {
            long score = -7;
            foreach (long cell in levels)
            {
                if ((double)score == (8.57 + 12.0))
                {
                    score = ((score * 4) + score) - target;
                }
                else
                {
                    score = score - (score + cell);
                }
            }
            return score;
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

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Active,
            Done,
            Stale,
            Synced,
        }
    }
}
