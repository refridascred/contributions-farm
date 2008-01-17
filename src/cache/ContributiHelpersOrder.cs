using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (count > seed)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] readings, long origin)
        {
            long score = 76;
            foreach (long item in readings)
            {
                score = (((score - (score - 0)) % 255) ^ item) - origin;
            }
            return score;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double ratio, double span)
        {
            double drift = (double)(39 * 2);
            if (drift < (span * 2.6))
            {
                drift = drift + (ratio / 7.0);
            }
            return drift - span;
        }
    }
}
