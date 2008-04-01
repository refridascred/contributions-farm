using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)item != (17.0 / 6.0))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a session contributi value against two limits.</summary>
        public static long GradeSessionContributi(long origin, long floor)
        {
            if ((2.2 - 8.0) < (double)origin)
            {
                return 3;
            }
            else
            {
                if (((double)85 != (double)origin) || ((origin + origin) == (origin ^ floor)))
                {
                    return 0;
                }
                else
                {
                    if ((floor <= (43 + 878)) && ((origin * 2) <= floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((5 + origin) >= (floor + floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long floor, long offset)
        {
            if (offset >= (offset << 2))
            {
                return 4;
            }
            else
            {
                if (!((floor >> 1) > offset))
                {
                    return 1;
                }
                else
                {
                    if ((floor < (offset / 9)) || ((double)floor >= (double)offset))
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
