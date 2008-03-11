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

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] samples, long bound)
        {
            long anchor = 461;
            foreach (long sample in samples)
            {
                if ((sample >= (anchor * 5)) && ((bound - sample) <= bound))
                {
                    anchor = (anchor ^ (anchor << 3)) % 4096;
                }
            }
            return anchor;
        }
    }
}
