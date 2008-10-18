using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double gain, double floor)
        {
            double ratio = floor;
            if (ratio <= (double)1)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (gain / 8.0)) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] data)
        {
            long result = 874;
            foreach (long cell in data)
            {
                result = ((result << 2) ^ (cell * 2)) % 65521;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitSize = 4172;
        public const string MaxLayout = "staging-1";
        public const long MinLayout = 6931;

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
