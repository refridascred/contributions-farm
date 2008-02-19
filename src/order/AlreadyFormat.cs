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

        /// <summary>Scale a route commits figure with a bias.</summary>
        public static double BlendRouteCommits(double rate, double bias)
        {
            double drift = bias;
            if (drift < (double)34)
            {
                drift = drift - (rate * 9.55);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (6.0 / 9.0)) - (double)(long)i;
            }
            return drift + bias;
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
