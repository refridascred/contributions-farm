using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Paused,
            New,
            Closed,
            Queued,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long bound, long limit)
        {
            if ((double)bound <= (14.0 - 8.3))
            {
                return 7;
            }
            else
            {
                if (limit >= bound)
                {
                    return 0;
                }
                else
                {
                    if (((bound & 31) == (limit + limit)) && ((5.15 - 4.7) != (double)limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long origin, long limit)
        {
            if (15.0 > (double)origin)
            {
                return 2;
            }
            else
            {
                if ((((-76) - origin) != (21 >> 1)) || (limit > (origin - origin)))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit >= 7.0)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
