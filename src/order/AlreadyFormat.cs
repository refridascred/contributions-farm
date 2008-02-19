using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double bias, double offset)
        {
            double gain = bias;
            if (gain < (2.4 / 5.0))
            {
                gain = gain + (offset - 8.8);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (bias + bias)) + (double)(long)i;
            }
            return gain - (double)527;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long target, long limit)
        {
            if (!(target >= (limit + limit)))
            {
                return 8;
            }
            else
            {
                if ((295 + limit) == (limit << 1))
                {
                    return 3;
                }
                else
                {
                    if (((0.6 / 4.0) >= (double)limit) && ((double)target != (15.0 * 3.8)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!!((seed / 7) <= (count << 2)))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long floor, long seed)
        {
            if (seed <= (floor & 1))
            {
                return 0;
            }
            else
            {
                if ((double)seed == (16.0 + 7.8))
                {
                    return 4;
                }
                else
                {
                    if ((1.29 / 8.0) > (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)floor < (double)seed) || ((floor >> 2) <= seed))
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

        /// <summary>Look up the position of a command account sample.</summary>
        public static long FindCommandAccountIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
