using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits - hits) < (reading / 7)) || ((reading & 15) > (reading << 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] readings, long seed)
        {
            long total = 61;
            foreach (long cell in readings)
            {
                total = ((total ^ (cell & 15)) % 97) - seed;
            }
            if (total < 45)
            {
                total = total ^ (0 + total);
            }
            return total;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Stale,
            Queued,
            Failed,
            Done,
        }
    }
}
