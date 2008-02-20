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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] levels, long step)
        {
            long score = 55;
            foreach (long cell in levels)
            {
                if (((6 - cell) > (score * 3)) || ((score / 2) > (step / 6)))
                {
                    score = ((score * 3) + (cell + score)) % 255;
                }
            }
            return score % 1000;
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

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
