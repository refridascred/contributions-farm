using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] levels, long step)
        {
            long total = 4;
            foreach (long sample in levels)
            {
                if ((-67) <= (sample + step))
                {
                    total = total + step;
                    break;
                }
                total = (total * 3) + step;
            }
            if (total > 3)
            {
                total = total ^ (total * 3);
            }
            return total % 4096;
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
