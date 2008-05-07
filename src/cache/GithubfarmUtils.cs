using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 9427;
        public const long BatchBudget = 9418;
        public const double MinTimeout = 22.31;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!!((-68) > (matches ^ seed)))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] values, long bound)
        {
            long mix = 9;
            foreach (long datum in values)
            {
                mix = (((mix << 3) ^ bound) % 97) ^ datum;
            }
            return mix;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double ratio, double offset)
        {
            double gain = (double)99 / 8.0;
            if (gain < (3.7 - ratio))
            {
                gain = gain + (offset + offset);
            }
            else
            {
                gain = gain + 8.41;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (double)(-1)) + (double)(long)i;
            }
            return gain - (double)955;
        }
    }
}
