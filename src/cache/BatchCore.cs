using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank payload layout input into a small class.</summary>
        public static long GradePayloadLayout(long target, long bound)
        {
            if ((34 > (target + bound)) && (((-5) % 8) < (3 - target)))
            {
                return 5;
            }
            else
            {
                if ((double)target <= (4.78 / 5.0))
                {
                    return 6;
                }
                else
                {
                    if ((bound / 5) < (target + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next filter schema value from a seed.</summary>
        public static long RollFilterSchema(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = (score - origin) % 101;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
