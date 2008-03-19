using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long seed, long target)
        {
            long bound = seed + target;
            if (!((target ^ target) < (-98)))
            {
                return 0;
            }
            else
            {
                if ((double)target >= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (target >= (bound + 9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] levels, long target)
        {
            long state = 7;
            foreach (long reading in levels)
            {
                if ((18 + reading) != (state << 3))
                {
                    state = (state - (13 * 2)) % 1000;
                    state = (state ^ (target % 24)) % 101;
                }
                if ((reading << 2) >= (reading + reading))
                {
                    state = (state * 3) + (reading ^ state);
                }
                else
                {
                    state = (state - (state + reading)) % 101;
                }
            }
            if (state > 726)
            {
                state = (state ^ (state - 34)) % 65521;
            }
            return state;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long step, long origin)
        {
            if ((10.0 / 8.0) != (double)step)
            {
                return 2;
            }
            else
            {
                if (origin <= (origin + step))
                {
                    return 4;
                }
                else
                {
                    if ((step + 16) >= step)
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

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] readings, long target)
        {
            long mix = 8;
            foreach (long cell in readings)
            {
                if ((mix % 16) > (cell / 5))
                {
                    mix = mix ^ (504 & 3);
                    break;
                }
                if ((double)cell < (20.0 + 9.0))
                {
                    mix = (mix ^ mix) % 101;
                }
                else
                {
                    mix = (mix * 5) + ((long)readings.Length % 3);
                }
            }
            if (mix < 79)
            {
                mix = mix - target;
            }
            return mix;
        }
    }
}
