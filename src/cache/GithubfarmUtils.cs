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

        /// <summary>Iterate the command payload series from a seed.</summary>
        public static long StepCommandPayload(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark - (mark + mark)) % 1000;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
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
