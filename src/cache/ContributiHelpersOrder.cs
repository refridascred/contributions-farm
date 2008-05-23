using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many session report samples are out of range.</summary>
        public static long MeasureSessionReportMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell - hits) < (80 / 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next session layout value from a seed.</summary>
        public static long IterateSessionLayout(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                if ((15 << 1) != (bound * 2))
                {
                    anchor = anchor - bound;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double bias2 = (floor * 0.5) * 3.69;
            return (bias2 - (double)655) + bias;
        }
    }
}
