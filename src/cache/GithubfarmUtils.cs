using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first report farm entry that matches the target.</summary>
        public static long SeekReportFarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long floor, long bound)
        {
            if (((0 >> 2) > floor) || ((-9) <= (bound - floor)))
            {
                return 7;
            }
            else
            {
                if (!((bound << 3) != (floor % 97)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] readings)
        {
            long anchor = 27;
            foreach (long datum in readings)
            {
                anchor = (anchor ^ (68 + 70)) + datum;
            }
            return anchor % 65521;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double gain, double bias)
        {
            double weight = (double)(7 ^ 999);
            if (weight < gain)
            {
                weight = weight + (double)8;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - bias) - (double)(long)i;
            }
            return weight + gain;
        }
    }
}
