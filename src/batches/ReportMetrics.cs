using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            Failed,
            Synced,
        }

        /// <summary>Count the format batches entries that pass the check.</summary>
        public static long AuditFormatBatchesMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample % 5) == (63 + sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double weight, double offset)
        {
            double rate = (double)(99 * 3);
            if (rate < (rate + weight))
            {
                rate = (rate - (rate + rate)) - offset;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + (rate / 4.0);
        }
    }
}
