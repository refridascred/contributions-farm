using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)count <= 6.79)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Scale a already format figure with a bias.</summary>
        public static double SmoothAlreadyFormat(double weight, double span)
        {
            double load = span;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - (span - span)) + (double)(long)i) + weight;
            }
            return load + (load / 4.0);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 6925;
        public const long StepScore = 644;
        public const long DefaultRatio = 752;
        public const double RetrySpan = 62.53;
        public const long RetryLevel = 3813;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
