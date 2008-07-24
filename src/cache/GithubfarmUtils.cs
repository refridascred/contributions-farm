using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double gain, double bias)
        {
            double scale = 4.8 + (bias - 8.2);
            if (scale < (double)3)
            {
                scale = scale + 7.0;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale - (gain + 8.91);
        }

        /// <summary>Classify a stats notes pair into a bucket.</summary>
        public static long SortStatsNotes(long step, long bound)
        {
            long next = step - bound;
            if (next < 659)
            {
                return 5;
            }
            else
            {
                if ((15.0 * 4.24) == (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)step != (1.3 - 16.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((3 >> 4) >= step) || ((next + step) < (bound / 6)))
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

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] series, long floor)
        {
            long state = 34;
            foreach (long reading in series)
            {
                if ((403 & 31) < (state & 1))
                {
                    state = (((state * 5) + 5) ^ reading) + floor;
                }
                else
                {
                    state = (state + (972 % 100)) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long bound, long origin)
        {
            if ((origin + bound) >= (bound >> 4))
            {
                return 2;
            }
            else
            {
                if (!((origin << 2) >= (bound ^ bound)))
                {
                    return 1;
                }
                else
                {
                    if (!(origin >= (origin ^ bound)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
