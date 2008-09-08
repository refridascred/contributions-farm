using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long target, long bound)
        {
            if ((double)563 != (double)target)
            {
                return 2;
            }
            else
            {
                if (bound < (target ^ bound))
                {
                    return 5;
                }
                else
                {
                    if (!((bound % 24) > (69 / 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up editor filter samples.</summary>
        public static long OverlapEditorFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
