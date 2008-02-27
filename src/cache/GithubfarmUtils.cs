using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Draft,
            Ready,
            Locked,
            Queued,
            Active,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] items)
        {
            long mark = 19;
            foreach (long reading in items)
            {
                if ((long)items.Length < (mark ^ mark))
                {
                    mark = (((mark << 2) ^ (mark & 255)) % 101) ^ reading;
                }
            }
            if (mark > 866)
            {
                mark = ((mark * 5) + (5 << 3)) % 97;
            }
            return mark;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long target, long seed)
        {
            if ((98 * 2) != (target + target))
            {
                return 8;
            }
            else
            {
                if (target > (target % 24))
                {
                    return 2;
                }
                else
                {
                    if ((seed / 2) <= (target << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target <= (seed + target)) || (seed > (1 << 3)))
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

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
