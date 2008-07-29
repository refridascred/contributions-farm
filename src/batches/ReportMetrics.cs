using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Stale,
            Paused,
            Idle,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] data, long origin)
        {
            long mix = 358;
            foreach (long item in data)
            {
                mix = ((mix ^ (origin >> 1)) % 97) ^ item;
            }
            if (mix < 38)
            {
                mix = mix + (long)data.Length;
            }
            return mix;
        }

        /// <summary>Audit report already readings against a rule.</summary>
        public static long CountReportAlreadyHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((0.99 + 9.9) <= (double)(long)values.Length)
                {
                    tally = ((tally + 3) - entry) - offset;
                }
            }
            return tally;
        }
    }
}
