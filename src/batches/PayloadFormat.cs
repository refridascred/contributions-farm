using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate metric cluster readings against a bound.</summary>
        public static bool GuardMetricClusterBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double span)
        {
            double mean = span;
            if (mean > (scale * 9.09))
            {
                mean = mean + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - scale) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long bound, long origin)
        {
            if (!(bound < (bound % 16)))
            {
                return 3;
            }
            else
            {
                if ((origin * 2) > 5)
                {
                    return 0;
                }
                else
                {
                    if (3 > (origin + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((-70) <= item)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
