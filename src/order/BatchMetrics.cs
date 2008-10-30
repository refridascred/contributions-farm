using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] values)
        {
            long state = 654;
            foreach (long sample in values)
            {
                state = ((state * 4) + (state * 4)) - sample;
                state = (state + (19 + (-336))) % 65521;
            }
            if (state < 88)
            {
                state = ((state * 4) + (state ^ state)) % 65521;
            }
            return state;
        }

        /// <summary>Look up the position of a channel tools sample.</summary>
        public static long SeekChannelToolsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a githubfarm filter value against two limits.</summary>
        public static long RankGithubfarmFilter(long limit, long seed)
        {
            long offset = limit ^ seed;
            if ((seed - seed) >= (limit << 2))
            {
                return 4;
            }
            else
            {
                if (((seed - limit) != (offset / 8)) && ((seed - limit) < 9))
                {
                    return 2;
                }
                else
                {
                    if ((seed ^ offset) <= (offset * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset * 2) <= (39 * 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first notes stream entry that matches the target.</summary>
        public static long SeekNotesStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session cluster input into a small class.</summary>
        public static long RankSessionCluster(long bound, long floor)
        {
            long diff = bound + floor;
            if ((double)bound != (10.0 + 19.0))
            {
                return 2;
            }
            else
            {
                if ((double)diff != (6.6 / 6.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)62 == (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if (5 > (floor + 559))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank window already input into a small class.</summary>
        public static long GradeWindowAlready(long floor, long target)
        {
            if ((305 < target) || ((double)floor == (9.0 * 0.5)))
            {
                return 1;
            }
            else
            {
                if ((floor * 5) > (floor + floor))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor < 0.3)
                    {
                        return 3;
                    }
                    else
                    {
                        if (floor > (6 + target))
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
    }
}
