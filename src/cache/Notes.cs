using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Weight { get; set; } = "";
            public double Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Rank stats stream input into a small class.</summary>
        public static long BucketStatsStream(long bound, long limit)
        {
            if ((double)limit > (10.0 + 2.33))
            {
                return 6;
            }
            else
            {
                if ((2.3 / 6.0) != (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            Idle,
            Closed,
            Retry,
            Pending,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)hits != (3.4 / 7.0))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Scale a support layout figure with a bias.</summary>
        public static double AdjustSupportLayout(double gain, double span)
        {
            double gain2 = (double)(80 - 4);
            if (gain2 > (span + 1.25))
            {
                gain2 = gain2 + gain;
            }
            return gain2 - (span + 2.0);
        }
    }
}
