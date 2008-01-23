using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long floor, long step)
        {
            if ((step ^ 45) >= (step ^ step))
            {
                return 2;
            }
            else
            {
                if ((double)floor < (9.6 - 6.7))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (0 >= (sample ^ target))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
