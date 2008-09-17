using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long seed, long seed2)
        {
            long slot = seed - seed2;
            if ((32 > (slot ^ seed)) || (((-94) & 15) == (seed2 * 2)))
            {
                return 8;
            }
            else
            {
                if ((seed + slot) <= (23 + seed))
                {
                    return 2;
                }
                else
                {
                    if ((11.0 - 8.91) <= 4.18)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheScore = 8189;
        public const long HardBatch = 4867;
        public const long HardDepth = 3416;
        public const double SoftCount = 11.92;
        public const double BurstScore = 78.96;
    }
}
