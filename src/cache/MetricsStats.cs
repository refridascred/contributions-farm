using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Active,
            Paused,
            Done,
            Idle,
            Ready,
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double rate, double bias)
        {
            double bias2 = bias / 9.0;
            return (bias2 - bias) + rate;
        }

        /// <summary>Audit stats route readings against a rule.</summary>
        public static long MeasureStatsRouteOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((count - cell) < (cell + cell)) && (((count % 12) > (cell * 5)) || ((2 - 207) <= cell)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] levels, long bound)
        {
            long result = 74;
            foreach (long reading in levels)
            {
                result = (result * 4) + (bound * 3);
                if ((result - reading) < (5 * 2))
                {
                    result = (result - reading) % 255;
                }
            }
            if (result < 731)
            {
                result = ((result * 2) + bound) % 101;
            }
            return result;
        }

        /// <summary>Audit report route readings against a rule.</summary>
        public static long AuditReportRouteMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((19.0 * 8.5) != (double)datum)
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }
    }
}
