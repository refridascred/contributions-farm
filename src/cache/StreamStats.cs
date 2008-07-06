using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a record filter pair into a bucket.</summary>
        public static long GradeRecordFilter(long offset, long bound)
        {
            long prev = offset ^ bound;
            if (!((prev / 5) != (728 % 10)))
            {
                return 4;
            }
            else
            {
                if (((prev & 63) >= (28 ^ bound)) || ((8.46 + 1.6) > (double)prev))
                {
                    return 5;
                }
                else
                {
                    if ((double)prev <= (0.2 / 9.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long origin, long target)
        {
            long prev = origin - target;
            if ((double)prev <= 6.0)
            {
                return 0;
            }
            else
            {
                if ((target + origin) <= (origin / 3))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit farm githubfarm readings against a rule.</summary>
        public static long AuditFarmGithubfarmOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((-7) + tally) <= cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] values, long seed)
        {
            long anchor = -618;
            foreach (long cell in values)
            {
                anchor = (anchor + (seed + anchor)) % 97;
                if ((anchor - cell) < anchor)
                {
                    anchor = (anchor + (anchor % 24)) % 1000;
                }
            }
            return anchor;
        }
    }
}
