using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length - cell) <= tally)
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items)
        {
            long anchor = 63;
            foreach (long value in items)
            {
                anchor = (anchor << 3) ^ (anchor ^ value);
            }
            if (anchor < 653)
            {
                anchor = (anchor + (5 - (-22))) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
