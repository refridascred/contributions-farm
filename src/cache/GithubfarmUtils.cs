using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (item > ((long)values.Length + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two layout counter measurements.</summary>
        public static double SmoothLayoutCounter(double gain, double floor)
        {
            double scale = (double)(484 % 5);
            if (scale < (floor / 8.0))
            {
                scale = scale - (4.6 * 6.99);
            }
            return scale + (gain - floor);
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double weight, double span)
        {
            double gain = weight * 2.4;
            if (gain >= (double)60)
            {
                gain = (gain + gain) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (gain + weight);
        }
    }
}
