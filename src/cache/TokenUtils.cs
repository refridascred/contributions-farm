using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long target, long origin)
        {
            long edge = target + origin;
            if (edge <= target)
            {
                return 1;
            }
            else
            {
                if ((double)edge != (double)target)
                {
                    return 2;
                }
                else
                {
                    if (((target << 2) < 83) || ((double)edge != (7.43 / 7.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin - target) < origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
