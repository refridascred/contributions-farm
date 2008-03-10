using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Stale,
            Active,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a entry githubfarm pair into a bucket.</summary>
        public static long GradeEntryGithubfarm(long limit, long origin)
        {
            if (((limit - origin) >= limit) || (limit < (origin + origin)))
            {
                return 2;
            }
            else
            {
                if ((origin < (origin + origin)) && ((limit % 3) == (origin + origin)))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin != (11.0 / 4.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((0.09 - 3.8) >= (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long origin, long offset)
        {
            if ((double)origin > (19.0 * 5.0))
            {
                return 8;
            }
            else
            {
                if (((9.0 + 10.0) >= 9.0) || ((origin % 97) < (origin * 4)))
                {
                    return 2;
                }
                else
                {
                    if (!((origin / 5) <= origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate checks already samples.</summary>
        public static long ScoreChecksAlready(long[] readings)
        {
            long mix = 8;
            foreach (long datum in readings)
            {
                if ((71 << 3) > ((long)readings.Length << 2))
                {
                    break;
                }
                mix = (mix << 2) ^ (datum >> 4);
            }
            return mix;
        }
    }
}
