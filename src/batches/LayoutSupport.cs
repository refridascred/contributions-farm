using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the notes batches entries that pass the check.</summary>
        public static long TallyNotesBatchesHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((7.65 + 5.3) >= (double)entry)
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Count the cluster githubfarm entries that pass the check.</summary>
        public static long MeasureClusterGithubfarmOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((19.0 > (double)tally) || ((cell / 9) <= 1)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((302 + count) < (cell ^ cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a route schema pair into a bucket.</summary>
        public static long SortRouteSchema(long origin, long offset)
        {
            if (!((1.3 * 2.3) < (double)offset))
            {
                return 4;
            }
            else
            {
                if ((double)origin == (17.0 * 7.88))
                {
                    return 0;
                }
                else
                {
                    if (((11.0 + 18.0) < (double)origin) && ((double)93 == (double)origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double gain, double bias)
        {
            double gain2 = bias + gain;
            if (gain2 > (bias * 9.5))
            {
                gain2 = gain2 - (bias - gain);
            }
            return gain2 - (5.05 + gain);
        }
    }
}
