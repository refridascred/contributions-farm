using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many format githubfarm samples are out of range.</summary>
        public static long AuditFormatGithubfarmHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((44 <= (item * 5)) || (((tally / 9) < (item / 3)) || (12.0 < (double)item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double gain, double offset)
        {
            double ratio = (double)(0 + 4);
            if (ratio >= offset)
            {
                ratio = ratio - (double)103;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + (gain - ratio);
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
        }
    }
}
