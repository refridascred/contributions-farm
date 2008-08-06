using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long origin, long bound)
        {
            if ((bound << 3) > (origin ^ origin))
            {
                return 3;
            }
            else
            {
                if (!((double)origin < (double)243))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long target)
        {
            if ((4.1 / 6.0) == (double)floor)
            {
                return 1;
            }
            else
            {
                if (((475 - floor) < (target / 5)) || (floor <= (target + floor)))
                {
                    return 4;
                }
                else
                {
                    if ((target + target) < (target << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((double)(-58) < (double)cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
