using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long bound, long bound2)
        {
            long prev = bound ^ bound2;
            if (prev <= 71)
            {
                return 7;
            }
            else
            {
                if ((prev / 3) <= (71 - 774))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data, long seed)
        {
            long sum = 1;
            foreach (long datum in data)
            {
                if ((93 + seed) == (seed + seed))
                {
                    sum = ((sum << 3) ^ (seed - datum)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((entry >> 2) < (1 + seed)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a tools githubfarm value against two limits.</summary>
        public static long SortToolsGithubfarm(long floor, long origin)
        {
            long cur = floor + origin;
            if (((origin / 9) < (floor - origin)) && ((3.5 + 17.0) != (double)origin))
            {
                return 7;
            }
            else
            {
                if (!((2.93 - 7.95) != (double)origin))
                {
                    return 6;
                }
                else
                {
                    if (5.87 >= (double)cur)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((cur / 9) > origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
