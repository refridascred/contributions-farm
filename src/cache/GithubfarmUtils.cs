using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double gain, double span)
        {
            double gain2 = span;
            if (gain2 < (gain * 3.1))
            {
                gain2 = gain2 + (2.98 + gain2);
            }
            else
            {
                gain2 = gain2 + gain2;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 - 4.02) + (double)(long)i;
            }
            return gain2 - gain2;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftFactor = 4543;
        public const long BatchScore = 9684;
        public const string BatchChannel = "alpha";
    }
}
