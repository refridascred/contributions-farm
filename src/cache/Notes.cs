using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardChecks = 7.28;
        public const double StepChecks = 89.29;
        public const double BurstScore = 1.29;

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double rate, double span)
        {
            double bias = (double)(9 / 6);
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias - span) + (double)(long)i) + rate;
            }
            return bias + (bias - 9.2);
        }

        /// <summary>Measure how many commits route samples are out of range.</summary>
        public static long MeasureCommitsRouteGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)sample <= (double)hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a report metrics reading by value.</summary>
        public static long SeekReportMetricsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
