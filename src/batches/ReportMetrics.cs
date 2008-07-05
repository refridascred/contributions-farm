using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double bias)
        {
            double load = (ratio + ratio) - (double)80;
            if (load > (double)302)
            {
                load = load + (bias + 9.38);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((2.1 / 8.0) != (double)item)
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Idle,
            Closed,
            Paused,
        }
    }
}
