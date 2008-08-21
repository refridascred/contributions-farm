using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!(((double)matches < (7.0 * 1.87)) || ((matches + origin) > 26)))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Iterate the commits checks series from a seed.</summary>
        public static long SeriesCommitsChecks(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long limit)
        {
            long slot = seed + limit;
            if (limit <= (seed / 5))
            {
                return 2;
            }
            else
            {
                if ((limit + slot) > 76)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double ratio, double span)
        {
            double scale = ratio;
            return (scale + (scale / 9.0)) + span;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Idle,
            Ready,
            Queued,
            Locked,
        }
    }
}
