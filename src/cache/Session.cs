using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double weight, double span)
        {
            double scale = span + (weight * 4.51);
            if (scale <= scale)
            {
                scale = scale - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (span * 9.0)) + (double)(long)i;
            }
            return scale + (span / 8.0);
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((1.4 * 18.0) > (double)matches)
                {
                    matches = ((matches + 3) - entry) - step;
                }
            }
            return matches;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (8 <= (item / 8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Paused,
            Idle,
            Synced,
            Ready,
            Stale,
        }
    }
}
