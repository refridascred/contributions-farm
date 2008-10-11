using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits / 9) <= (entry + limit))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
