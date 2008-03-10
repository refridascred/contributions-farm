using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the format metrics entries that pass the check.</summary>
        public static long TallyFormatMetricsOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((item - seed) >= (42 * 4)) && ((double)hits != (double)item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!(((0.13 - 8.55) < (double)target) || ((5.8 * 9.76) < (double)target)))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
