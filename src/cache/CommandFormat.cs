using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long floor, long target)
        {
            if ((floor < (target * 4)) || ((4 / 5) <= (target - floor)))
            {
                return 0;
            }
            else
            {
                if (((target >> 2) <= (floor / 8)) && ((5.11 * 16.0) <= (double)target))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up commits stream samples.</summary>
        public static long PairCommitsStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                if ((double)step <= (8.2 - 13.0))
                {
                    score = (score ^ score) % 255;
                    score = (score ^ step) % 101;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long origin, long offset)
        {
            if ((82 >= (offset + offset)) || ((origin << 2) <= (origin * 5)))
            {
                return 7;
            }
            else
            {
                if (((double)628 != (double)offset) && ((double)origin >= 14.0))
                {
                    return 4;
                }
                else
                {
                    if ((19.0 + 3.0) == (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
