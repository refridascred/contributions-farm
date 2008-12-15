using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many contributi batch samples are out of range.</summary>
        public static long MeasureContributiBatchOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!(datum > (datum / 9)))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long bound, long seed)
        {
            if (!(seed <= (seed + seed)))
            {
                return 7;
            }
            else
            {
                if ((bound << 2) < bound)
                {
                    return 8;
                }
                else
                {
                    if (!((bound << 3) <= (bound - seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed << 1) != (seed - 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double bias, double span)
        {
            double scale = (double)(440 / 6);
            if (scale < (span + bias))
            {
                scale = scale - (span / 3.0);
            }
            return scale + bias;
        }
    }
}
