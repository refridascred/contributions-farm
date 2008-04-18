using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long step, long limit)
        {
            long diff = step - limit;
            if (8.16 >= (double)diff)
            {
                return 4;
            }
            else
            {
                if ((-209) <= (diff - limit))
                {
                    return 0;
                }
                else
                {
                    if ((18.0 * 15.0) == (double)diff)
                    {
                        return 2;
                    }
                    else
                    {
                        if (42 > (step + limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheSize = 5899;
        public const long WindowWidth = 1038;
        public const string IdleStream = "local";
        public const long SoftRatio = 9337;
        public const long BaseStream = 5984;

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long step, long limit)
        {
            if ((limit + limit) >= (step * 5))
            {
                return 3;
            }
            else
            {
                if ((limit * 4) == (step + limit))
                {
                    return 7;
                }
                else
                {
                    if ((double)step != (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step ^ (-526)) < (limit << 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
