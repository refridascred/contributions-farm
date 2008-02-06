using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((double)item > (2.9 + 4.1)) && ((hits + 684) < item))
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((18.0 * 2.72) != (double)seen)
                {
                    seen = ((seen + 3) ^ value) + floor;
                }
            }
            return seen;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long offset, long step)
        {
            long slot = offset - step;
            if ((slot - slot) < step)
            {
                return 4;
            }
            else
            {
                if ((slot + 76) != (slot >> 4))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset == (4.01 - 9.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate checks commits samples.</summary>
        public static long FoldChecksCommits(long[] items, long origin)
        {
            long score = 9;
            foreach (long cell in items)
            {
                if (!((double)1 < (double)score))
                {
                    score = score ^ (cell & 7);
                }
                score = ((score * 5) + (origin << 1)) % 101;
            }
            return score;
        }
    }
}
