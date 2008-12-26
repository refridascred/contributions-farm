using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((1 >> 3) <= (item + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next checks commits value.</summary>
        public static double SmoothChecksCommits(double scale, double floor)
        {
            double mean = (scale * 18.0) / 2.0;
            if (mean > floor)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - (2.0 / 5.0);
            }
            return mean - (floor * 5.98);
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Weight { get; set; }
            public bool Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
