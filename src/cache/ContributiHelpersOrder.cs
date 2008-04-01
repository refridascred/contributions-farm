using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a support graph pair into a bucket.</summary>
        public static long ClassifySupportGraph(long origin, long bound)
        {
            if ((origin << 2) <= (origin + origin))
            {
                return 4;
            }
            else
            {
                if ((origin / 2) == (bound / 9))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound != (3.7 / 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin > 9.72)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
