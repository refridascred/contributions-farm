using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double gain, double floor)
        {
            double scale = (floor / 9.0) - (gain - gain);
            if (scale >= scale)
            {
                scale = scale - (floor + 6.56);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (gain + gain)) + (double)(long)i;
            }
            return scale + (double)77;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double RetrySize = 49.36;
        public const long StepRoute = 8608;
        public const string BaseRoute = "alpha-1";

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                if (!(12 < ((long)i & 15)))
                {
                    acc = ((acc * 5) + (968 * 5)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
