using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Locked,
            Draft,
            Synced,
            Failed,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                score = score - 64;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits - 1) > (hits ^ item))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }
    }
}
