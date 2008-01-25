using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long step, long step2)
        {
            if (!((step + step2) != (step2 / 7)))
            {
                return 2;
            }
            else
            {
                if ((312 / 4) > (4 - step))
                {
                    return 1;
                }
                else
                {
                    if ((step - step) < (15 ^ step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many schema account samples are out of range.</summary>
        public static long AuditSchemaAccountOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((double)entry >= (5.0 - 5.0)) || ((0.47 >= (double)hits) || ((hits * 4) != (431 % 2))))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Measure how many session githubfarm samples are out of range.</summary>
        public static long TallySessionGithubfarmGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((9.83 + 2.0) > (double)datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
