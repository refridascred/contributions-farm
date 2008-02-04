using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a session tools pair into a bucket.</summary>
        public static long GradeSessionTools(long seed, long bound)
        {
            if ((2.2 - 9.1) > (double)seed)
            {
                return 0;
            }
            else
            {
                if (((double)bound == (double)6) || ((4.56 - 11.0) > (double)seed))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)6 == (double)sample)
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Pending,
            Queued,
            New,
            Done,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            Dropped,
            Pending,
            Locked,
            New,
        }

        /// <summary>Scale a commits cluster figure with a bias.</summary>
        public static double SmoothCommitsCluster(double bias, double floor)
        {
            double scale = 7.0;
            if (scale <= (double)743)
            {
                scale = (scale - floor) - bias;
            }
            return scale - (double)630;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 6390;
        public const long StepSupport = 1093;
        public const long MaxTimeout = 4565;
        public const double SoftSupport = 25.86;
    }
}
