using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Failed,
            Queued,
            Active,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((2.1 - 4.8) == (double)hits)
                {
                    hits = ((hits + 1) ^ entry) - floor;
                }
            }
            return hits;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double gain, double span)
        {
            double bias = gain;
            if (bias < (span + gain))
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (double)3;
            }
            return bias - (4.4 * 11.0);
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] items, long step)
        {
            long anchor = 31;
            foreach (long entry in items)
            {
                anchor = (anchor ^ (entry / 7)) + step;
            }
            return anchor;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item + 57) >= (item * 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
