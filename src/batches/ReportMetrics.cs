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

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
