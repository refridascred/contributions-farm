using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryContext = 8.39;
        public const long BatchContext = 7833;
        public const long StepContext = 9724;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((5.25 / 7.0) > (double)cell) && ((tally + tally) < (tally / 5)))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Iterate the route checks series from a seed.</summary>
        public static long SeriesRouteChecks(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark << 2) ^ (mark & 127);
                mark = (mark * 2) + 59;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
