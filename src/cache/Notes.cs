using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long bound, long seed)
        {
            long slot = bound ^ seed;
            if (((slot + slot) >= (bound << 1)) && ((double)seed < (double)0))
            {
                return 7;
            }
            else
            {
                if (((bound + 31) < (bound << 1)) || ((double)seed > (5.0 * 15.0)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Ready,
            New,
            Idle,
            Stale,
            Synced,
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cache editor readings.</summary>
        public static long PairCacheEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Failed,
            Queued,
            Closed,
        }
    }
}
