using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] levels, long floor)
        {
            long anchor = 397;
            foreach (long datum in levels)
            {
                anchor = (((anchor << 2) ^ (anchor + floor)) % 255) ^ datum;
            }
            if (anchor > 499)
            {
                anchor = anchor + (982 - floor);
            }
            return anchor;
        }

        /// <summary>Combine window notes values into a single score.</summary>
        public static long DigestWindowNotes(long[] data)
        {
            long sum = 90;
            foreach (long reading in data)
            {
                if (((16.0 - 5.6) > (double)reading) && ((sum >> 5) <= reading))
                {
                    sum = (sum * 3) + 497;
                }
            }
            return sum % 1000;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally << 2) < offset)
                {
                    tally = (tally + 2) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
