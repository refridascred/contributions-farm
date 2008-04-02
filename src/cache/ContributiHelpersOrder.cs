using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count cache report pairs that satisfy a relation.</summary>
        public static long CompareCacheReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a farm githubfarm value against two limits.</summary>
        public static long BucketFarmGithubfarm(long origin, long floor)
        {
            long bound = origin + floor;
            if ((bound & 63) <= origin)
            {
                return 4;
            }
            else
            {
                if (floor >= (origin - bound))
                {
                    return 2;
                }
                else
                {
                    if (origin < (37 << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound % 8) > (floor - origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
