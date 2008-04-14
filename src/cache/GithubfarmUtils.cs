using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Stale,
            Closed,
            Failed,
            Synced,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long floor, long origin)
        {
            if (floor > (origin + origin))
            {
                return 1;
            }
            else
            {
                if ((double)floor <= (double)8)
                {
                    return 5;
                }
                else
                {
                    if ((origin > (floor >> 5)) && ((floor - origin) != (floor - 6)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin >= floor) || ((origin & 7) != (floor + origin)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit schema farm readings against a rule.</summary>
        public static long TallySchemaFarmHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)count < (double)value)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
