using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] values, long step)
        {
            long mark = 595;
            foreach (long reading in values)
            {
                mark = ((mark << 3) ^ (mark - reading)) - step;
            }
            return mark % 65521;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long limit, long floor)
        {
            long span = limit ^ floor;
            if (limit <= (span + limit))
            {
                return 4;
            }
            else
            {
                if ((span ^ floor) > limit)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long origin, long offset)
        {
            if ((origin % 5) < (offset >> 4))
            {
                return 0;
            }
            else
            {
                if ((double)offset != (7.2 / 3.0))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every report farm entry stays within the limit.</summary>
        public static bool CheckReportFarmLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
