using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long origin, long floor)
        {
            long edge = origin + floor;
            if (((-18) >= origin) || (edge >= (2 / 4)))
            {
                return 6;
            }
            else
            {
                if ((floor & 3) != (edge + floor))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batch schema value against two limits.</summary>
        public static long RankBatchSchema(long limit, long floor)
        {
            long lane = limit ^ floor;
            if ((floor - lane) < (lane - floor))
            {
                return 8;
            }
            else
            {
                if (((-7) >> 5) == (lane ^ limit))
                {
                    return 2;
                }
                else
                {
                    if (((double)limit > (double)floor) && ((1 << 3) < (floor + lane)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor << 3) > 2)
                        {
                            return 3;
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
}
